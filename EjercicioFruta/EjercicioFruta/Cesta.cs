using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFruta
{
    public partial class Cesta : Form
    {
        List<Frutas> listadoFrutas = ObjetoCesta.ObtenerListaFrutas();
        int contadorProductos = 0;
        float precioTotal = 0;

        public Cesta()
        {
            InitializeComponent();
            DatosCesta();
            MostrarCesta();
        }

        private void DatosCesta()
        {
            contadorProductos = 0;
            precioTotal = 0; 

            foreach ( Frutas frutas in listadoFrutas) 
            {
                precioTotal = precioTotal + frutas.Precio;
                contadorProductos++;
            }
            lblProductos.Text = contadorProductos.ToString();
            lblPrecio.Text = precioTotal.ToString() + "€";
        }

        private void MostrarCesta()
        {
          
            flowLayoutPanel1.Controls.Clear();
            foreach (Frutas frutas in listadoFrutas)
            {
                // Crear el panel contenedor

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panel.BorderStyle = BorderStyle.FixedSingle;

             
                // Boton informacion producto 

                Button button = new Button();
                button.Text = frutas.Nombre.ToString();
                button.Click += Button_Click;
                button.Tag = frutas;
                button.AutoSize = true;
                button.Dock = DockStyle.Bottom;


                // Button agregar producto cesta 

                Button eliminar = new Button();
                eliminar.Text = "Eliminar";
                eliminar.Click += Eliminar_Click; ;
                eliminar.Tag = frutas;
                eliminar.Size = new Size(100, 30);
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                eliminar.Dock = DockStyle.Top;

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

                panel.Controls.Add(eliminar);
                panel.Controls.Add(button);
                panel.Controls.Add(pictureBox);

                // Agregar el panel contenedor al FlowLayoutPanel principal
                flowLayoutPanel1.Controls.Add(panel);

            }


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Frutas fruta = button.Tag as Frutas;
            MessageBox.Show("Producto eliminado!!");
            listadoFrutas.Remove(fruta);
            DatosCesta();
            MostrarCesta();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frutas fruta = btn.Tag as Frutas;
            MessageBox.Show(fruta.Nombre + "/ Precio: " + fruta.Precio.ToString() + "€");

        }
    }
}

