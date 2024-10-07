using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;

namespace EjercicioBrainTraining
{
    public partial class Form1 : Form
    {
        int contador = 30;
        int contadorPuntos = 0;
        static string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void InsertarRanking()
        {
            DateTime fechaActual = DateTime.Now; 
            Console.WriteLine(fechaActual); 
            string usuario = textBox2.Text;
            int puntos = contadorPuntos;
            string fecha = fechaActual.ToString();

            Crud crud = new Crud(ruta);
            Ranking ranking = new Ranking(usuario, puntos,fecha);
            
            crud.InsertarRanking(ranking);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                int resultadoNumeros = 0;
                int numero1 = int.Parse(label3.Text);
                int numero2 = int.Parse(label5.Text);
                string operacion = label4.Text;
                int resultado = Convert.ToInt16(textBox1.Text);
                int resultadoOperaciones = Resultado(numero1, numero2,operacion);

                if( resultadoOperaciones == resultado) 
                {
                    contadorPuntos++;
                    label2.Text = contadorPuntos.ToString();
                }
                else
                {
                    contadorPuntos--;
                    label2.Text = contadorPuntos.ToString();
                }

                textBox1.Text = "";
                GenerarNumeros();
            }
        }

        private int Resultado( int numero1, int numero2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                   return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    return numero1 / numero2;
            }

            return 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                textBox2.Visible = true;
               
            }
        }

        private void GenerarNumeros()
        {
            string[] operaciones = { "+", "-", "*", "/" };
            int nivel = Convert.ToInt16(nivelNumero.Text);
            label3.Text = (random.Next(1, 10) * nivel).ToString();
            label4.Text = operaciones[random.Next(0, operaciones.Length)];
            label5.Text = (random.Next(1, 10) * nivel).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo.Text = contador.ToString();
            contador--;
            if (contador == 0) 
            {
                timer1.Stop();
                MessageBox.Show("Total de puntos conseguidos" + contadorPuntos);
                InsertarRanking();
                contador = 30;

                ResetLabels();
            }
            
        }

        private void ResetLabels()
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            textBox2.Text = "";
        }
    

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Enabled = false;
                timer1.Start();
                textBox1.Visible = true;
                GenerarNumeros();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Crud crud = new Crud(ruta);
           dataGridView1.DataSource = crud.SelectRanking();

        }
    }
}
