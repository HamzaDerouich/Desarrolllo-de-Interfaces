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

namespace Alummno
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
            Crud crud = new Crud(ruta);
            dataGridView1.DataSource = crud.SelectAlumno() ;

            foreach (ClaseDam alumno in crud.SelectAlumno())
            {
                Button button = new Button();
                button.Text = alumno.ToString();
                button.Tag = alumno;
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);  
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btnMostrar = (Button)sender;
            ClaseDam alumno = btnMostrar.Tag as ClaseDam;
            MessageBox.Show("Las calificaciones de: " + alumno.Nombre + "Nota SGE: " + alumno.Age + "Nota PSP:  " + alumno.Psp + "Nota P.Multimedia:  " + alumno.Pmm );
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string expediente = txtExpediente.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string apellidos = txtApellido.Text.ToString();
            int SGE = Convert.ToInt16(txtSGE.Text.ToString());
            int PSP = Convert.ToInt16(txtSGE.Text.ToString());
            int AGE = Convert.ToInt16(txtSGE.Text.ToString());
            int PMP = Convert.ToInt16(txtSGE.Text.ToString());

            ClaseDam alumno = new ClaseDam(expediente,nombre,apellidos,SGE,PSP,AGE,PMP);

            Crud crud = new Crud(ruta);
            crud.InsertAlumno(alumno);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string expediente = txtExpediente.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string apellidos = txtApellido.Text.ToString();
            int SGE = Convert.ToInt16(txtSGE.Text.ToString());
            int PSP = Convert.ToInt16(txtSGE.Text.ToString());
            int AGE = Convert.ToInt16(txtSGE.Text.ToString());
            int PMP = Convert.ToInt16(txtSGE.Text.ToString());

            ClaseDam alumno = new ClaseDam(expediente, nombre, apellidos, SGE, PSP, AGE, PMP);

            Crud crud = new Crud(ruta);
            crud.DeleteAlumno(alumno);
        }
    }
}
