using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_a_datos__Ejercicio_Casa_
{
    

    public partial class Form1 : Form
    {
        static string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CrudAlturasEmpleados accesoAlturas = new CrudAlturasEmpleados(ruta);
            dataGridViewAlturas.DataSource = accesoAlturas.SelectAlturas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CrudAlturasEmpleados accesoAlturas = new CrudAlturasEmpleados(ruta);
            dataGridView1.DataSource = accesoAlturas.SelectEmpleados();
            foreach( Empleado empleado in accesoAlturas.SelectEmpleados())
            {
                FlowLayoutPanel panelObjetos = new FlowLayoutPanel();
              
                Button btn = new Button();
                string rutaImagen = empleado.Image.ToString();
                PictureBox pictureBox = new PictureBox();
                pictureBox.LoadAsync(rutaImagen);

                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
             
                
                btn.Text = empleado.Password.ToString();
                btn.Tag = empleado ;
                btn.BackColor = Color.White;
                btn.AutoSize = btn.AutoSize;
                btn.Click += Btn_Click;

                panelObjetos.Controls.Add(btn);
                panelObjetos.Controls.Add(pictureBox);


                flowLayoutPanel1.Controls.Add(panelObjetos);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
           Button button = (Button)sender;
           Empleado empleado = button.Tag as Empleado;
           MessageBox.Show("Password: " + button.Text + " Nivel: " + empleado.Nivel.ToString()); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.ToString();
            string password = txtPassword.Text.ToString();
            int nivel = Convert.ToInt16(txtNivel.Text);
            string imagen = txtImagen.Text.ToString();
            string imagenAlt = txtImagenAlt.Text.ToString();

            Empleado empleado = new Empleado(dni,password,nivel,imagen,imagenAlt);

            CrudAlturasEmpleados accesoEmpleados = new CrudAlturasEmpleados(ruta);
            accesoEmpleados.InsertEmpleados(empleado);
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string provincia = txtProvincia.Text.ToString();
            string situacion_alt_maxima = txtSituacionMax.Text.ToString();
            int altura_maxima = Convert.ToInt16(txtAlturaMax.Text.ToString());
            string situacion_alt_minima = txtSituacionMin.Text.ToString();
            int altura_minima = Convert.ToInt16(txtAlturaMin.Text.ToString());

            Altura altura = new Altura(provincia, situacion_alt_maxima, altura_maxima, situacion_alt_minima, altura_minima);

            CrudAlturasEmpleados accesoBaseDatos = new CrudAlturasEmpleados(ruta);
            accesoBaseDatos.InsertAlturas(altura);
        }
    }
}
