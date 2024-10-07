using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        static string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        public void CargarMensajes()
        {
            flowLayoutPanel1.Controls.Clear();
            Crud crud = new Crud(ruta);
            List<Usuario> list = crud.ConsultarChat();

            for (int i = 0; i < list.Count; i++)
            {
                Usuario usuario = list[i];

                // Crear un Label para cada mensaje del usuario
                Label label = new Label();
                label.Text = "Usuario: " + usuario.Name + "\nMensaje: " + usuario.Text;
                label.AutoSize = true;

                // Establecer el máximo tamaño del Label para que el texto haga un salto de línea si es demasiado largo
                label.MaximumSize = new Size(300, 0);
                label.BorderStyle = BorderStyle.Fixed3D;
                label.BackColor = Color.Coral;

                label.Margin = new Padding(5);

                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud(ruta);
            List<Usuario> list = crud.ConsultarChat();
            id = list.Max(u => u.Id) + 1;

            string usuario = "usuario_local_hamza";
            string texto = textBox1.Text;
            Usuario user = new  Usuario(id,usuario, texto);

            crud.InsertarMensaje(user);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarMensajes();
        }

        
    }
}
