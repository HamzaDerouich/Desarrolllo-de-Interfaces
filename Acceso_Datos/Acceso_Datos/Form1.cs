using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos
{
    public partial class Form1 : Form
    {

        static string path = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos(path);
            dataGridView1.DataSource = accesoBaseDatos.Select();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string provincia = txtProvincia.Text.ToString();
            string situacion_alt_maxima = txtSituacionMax.Text.ToString();
            int altura_maxima = Convert.ToInt16(txtAlturaMax.Text.ToString());
            string situacion_alt_minima = txtSituacionMin.Text.ToString();
            int altura_minima = Convert.ToInt16(txtAlturaMin.Text.ToString());

            Altura altura = new Altura(provincia,situacion_alt_maxima,altura_maxima,situacion_alt_minima,altura_minima);

            AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos(path);
            accesoBaseDatos.Insert(altura);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string provincia = txtProvincia.Text.ToString();
            string situacion_alt_maxima = txtSituacionMax.Text.ToString();
            int altura_maxima = Convert.ToInt16(txtAlturaMax.Text.ToString());
            string situacion_alt_minima = txtSituacionMin.Text.ToString();
            int altura_minima = Convert.ToInt16(txtAlturaMin.Text.ToString());

            Altura altura = new Altura(provincia, situacion_alt_maxima, altura_maxima, situacion_alt_minima, altura_minima);

            AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos(path);
            accesoBaseDatos.Delete(altura);
        }
    }
}
