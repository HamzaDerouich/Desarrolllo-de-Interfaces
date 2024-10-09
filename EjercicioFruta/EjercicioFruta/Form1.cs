using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFruta
{
  
    public partial class Form1 : Form
    {
        static string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        static CRUD crud = new CRUD(ruta);
        static  List<Frutas> frutas = crud.ObtenerFrutas();

        public Form1()
        {
            InitializeComponent();
        }

        private void CargarImagenes()
        {
          
            dataGridView1.DataSource = frutas;
        }

        private void MostrarCatalogo()
        {
            foreach (Frutas frutas in frutas) 
            {
                // Crear el panel contenedor
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true; // Ajustar el tamaño automáticamente según el contenido
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panel.BorderStyle = BorderStyle.FixedSingle; // Para visualizar mejor los bordes (opcional)

                // Crear labels precios

                Label lbl = new Label();
                lbl.Text = "*["+frutas.Nombre + ", "+ frutas.Precio+"]";
                lbl.ForeColor = Color.White;
                lbl.Margin = new Padding(3);
                lbl.AutoSize = true;

                

                // Crear el botón
                Button button = new Button();
                button.Text = frutas.Nombre.ToString();
                button.Click += Button_Click;
                button.Tag = frutas;
                button.AutoSize = true;
                button.Dock = DockStyle.Bottom; // Ubica el botón en la parte inferior del panel
                

                // Crear el PictureBox

                MemoryStream stream = new MemoryStream(frutas.Imagen); // Convertir la imagen en un stream
                Bitmap imagen = new Bitmap(stream); // Convertir el stream a una imagen
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imagen;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Height = 100;  // Ajustar altura de la imagen
                pictureBox.Width = 100;   // Ajustar ancho de la imagen
                pictureBox.Dock = DockStyle.Top; // Colocar la imagen en la parte superior del panel

                // Agregar el PictureBox , botón y label al panel
                panel.Controls.Add(button);       // Añadir el botón al panel
                panel.Controls.Add(pictureBox);   // Añadir la imagen al panel

                // Agregar el panel contenedor al FlowLayoutPanel principal
                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel2.Controls.Add(lbl);


            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frutas fruta  = btn.Tag as Frutas;
            MessageBox.Show(fruta.Nombre + "/" + fruta.Precio.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarImagenes();
            MostrarCatalogo();
        }
    }
}
