using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDi
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string[] imagenes =
        {
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\1.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\2.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\3.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\4.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\5.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\6.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\7.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\8.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\9.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\10.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\11.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\12.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\13.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\14.JPG",
             "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\15.JPG",
              "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\16.JPG",
              "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\17.JPG",
              "C:\\Users\\Usuario\\source\\repos\\ExamenDi\\ExamenDi\\imagenes\\18.JPG",
        };

        static string[] imagenes_no_repetidas = new string[15];

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            CargarImagenes();
            for (int i = 0; i < imagenes_no_repetidas.Length; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagenes_no_repetidas[i]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }


        int j = 0;
        private void CargarImagenes()
        {
          bool esta_la_imagen = false;
          int i = 0;
          while( i < imagenes_no_repetidas.Length)
            {
                string ruta = imagenes[random.Next(0,imagenes.Length)];
                if (!Esta(ruta))
                {
                    imagenes_no_repetidas[i] = ruta;
       
                }
                else
                {
                    while (true)
                    {
                        ruta = imagenes[random.Next(0, imagenes.Length)];
                        if (!Esta(ruta))
                        {
                            imagenes_no_repetidas[i] = ruta;
                            break;
                        }
                    }
                }


                
                i++;
            }

        }

        private bool Esta(string ruta)
        {
            for (int i = 0; i < imagenes_no_repetidas.Length; i++)
            {
                if (imagenes_no_repetidas[i] == ruta) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
