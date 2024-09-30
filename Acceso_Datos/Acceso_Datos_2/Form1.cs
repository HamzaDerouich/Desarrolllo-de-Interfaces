using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true;";
            Crud crud = new Crud(ruta);
            dataGridView1.DataSource = crud.SelectAltura();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtenemos los datos de los textBox 

            string Provincia = txtProvincia.Text.ToString();
            string SituacionAltMaxima = txtSAM.Text.ToString();
            int AlturaMaxima = Convert.ToInt16(txtAM.Text.ToString());
            string SituacionAltMinima = txtSAMI.Text.ToString();
            int AlturaMinima = Convert.ToInt16(txtALMI.Text.ToString());

            Altura altura = new Altura(Provincia, SituacionAltMaxima, AlturaMaxima, SituacionAltMinima, AlturaMinima);

            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true;";
            Crud crud = new Crud(ruta);
            crud.InsertAltura(altura);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Provincia = txtProvincia.Text.ToString();
            string SituacionAltMaxima = txtSAM.Text.ToString();
            int AlturaMaxima = Convert.ToInt16(txtAM.Text.ToString());
            string SituacionAltMinima = txtSAMI.Text.ToString();
            int AlturaMinima = Convert.ToInt16(txtALMI.Text.ToString());

            Altura altura = new Altura(Provincia, SituacionAltMaxima, AlturaMaxima, SituacionAltMinima, AlturaMinima);

            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true;";
            Crud crud = new Crud(ruta);
            crud.DeleteAltura(altura);
        }

       
    }
}
