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
    public partial class Catalogo : Form
    {
        static string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        static CRUD crud = new CRUD(ruta);
        static List<Frutas> frutas = crud.ObtenerFrutas();
        public Catalogo()
        {
            InitializeComponent();
            MostrarCatalogo();
        }

        private void MostrarCatalogo()
        {
            foreach (Frutas frutas in frutas)
            {
                // Crear el panel contenedor
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panel.BorderStyle = BorderStyle.FixedSingle; 

                // Crear labels precios

                Label lbl = new Label();
                lbl.Text = "*[" + frutas.Nombre + ", " + frutas.Precio + "]";
                lbl.ForeColor = Color.White;
                lbl.Margin = new Padding(3);
                lbl.AutoSize = true;



                // Boton informacion producto 

                Button button = new Button();
                button.Text = frutas.Nombre.ToString();
                button.Click += Button_Click;
                button.Tag = frutas;
                button.AutoSize = true;
                button.Dock = DockStyle.Bottom;


                // Button agregar producto cesta 

              

                Button agregar = new Button();
                agregar.Text = "Agregar Fruta";
                agregar.Click += Agregar_Click; 
                agregar.Tag = frutas;
                agregar.Size = new Size(100,30);
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                agregar.Dock = DockStyle.Top;

                // Crear el PictureBox

                MemoryStream stream = new MemoryStream(frutas.Imagen); 
                Bitmap imagen = new Bitmap(stream); 
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imagen;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Height = 100; 
                pictureBox.Width = 100;   
                pictureBox.Dock = DockStyle.Top; 

                // Añadimos los elemntos al panel 
                
                panel.Controls.Add(agregar);   
                panel.Controls.Add(button);     
                panel.Controls.Add(pictureBox);  

                // Agregar el panel contenedor al FlowLayoutPanel principal
                flowLayoutPanel1.Controls.Add(panel);

            }

            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frutas fruta = btn.Tag as Frutas;
            ObjetoCesta.AgregarProductoCesta(fruta);
            MessageBox.Show("Producto agregado!!");

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frutas fruta = btn.Tag as Frutas;
            MessageBox.Show(fruta.Nombre + "/ Precio: " + fruta.Precio.ToString() + "€");

        }
    }
}
