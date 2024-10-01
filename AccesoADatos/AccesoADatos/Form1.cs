using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoADatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ConexionBaseDatos conexionBaseDatos = new ConexionBaseDatos();
            dataGridView1.DataSource = conexionBaseDatos.ObtenerDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtenemos los datos de los textbox

            string provincia = textBox1.Text.ToString();
            string situacionAltMax = textBox2.Text.ToString() ;
            int alturaMaxima = Convert.ToInt16(textBox3.Text);
            string situacionAltMin = textBox4.Text.ToString();
            int alturaMinima = Convert.ToInt16(textBox5.Text);

            // Instancimaos el objeto para insertar los datos 

            Alturas altura = new Alturas(provincia,situacionAltMax,alturaMaxima,situacionAltMin,alturaMinima);
            ConexionBaseDatos conexion = new ConexionBaseDatos();
            conexion.InsertarDatos(altura);

        }
    }
}
