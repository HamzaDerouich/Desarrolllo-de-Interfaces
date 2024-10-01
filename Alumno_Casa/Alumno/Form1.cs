using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            Crud crud = new Crud(ruta);
            dataGridView1.DataSource = crud.SelectAltura();
            dataGridView1.Refresh();

            foreach( Alumno alumno in crud.SelectAltura())
            {
                Button btn = new Button();
                btn.Text = alumno.Nombre;
                btn.Tag = alumno;
                btn.BackColor = Color.Gray;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn); 
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
           Button button = (Button) sender;
           Alumno alumno = (Alumno) button.Tag;
            MessageBox.Show("Notas[ " + alumno.Sge + " - " + alumno.Di + " - " + alumno.Ad + " - " + alumno.Psp + " - " +  alumno.Pmm  +" ]"); 

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string expediente = txtExpediente.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string apellidos = txtApellido.Text.ToString();
            int SGE = Convert.ToInt16(txtSGE.Text);
            int DI = Convert.ToInt16(txtSGE.Text);
            int AD = Convert.ToInt16(txtSGE.Text);
            int PSP = Convert.ToInt16(txtSGE.Text);
            int PMM = Convert.ToInt16(txtSGE.Text);

            Alumno alumno = new Alumno(expediente,nombre,apellidos,SGE,DI,AD,PSP,PMM);

            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            Crud crud = new Crud(ruta);
            crud.InsertarAlumno(alumno);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string expediente = txtExpediente.Text.ToString();
            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            Crud crud = new Crud(ruta);
            crud.DeleteAlumno(expediente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string expediente = txtExpediente.Text.ToString();
            string nombre = txtNombre.Text.ToString();
            string apellidos = txtApellido.Text.ToString();
            int SGE = Convert.ToInt16(txtSGE.Text);
            int DI = Convert.ToInt16(txtSGE.Text);
            int AD = Convert.ToInt16(txtSGE.Text);
            int PSP = Convert.ToInt16(txtSGE.Text);
            int PMM = Convert.ToInt16(txtSGE.Text);

            Alumno alumno = new Alumno(expediente, nombre, apellidos, SGE, DI, AD, PSP, PMM);

            string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            Crud crud = new Crud(ruta);
            crud.UpdateAlumno(alumno);
        }
    }
}
