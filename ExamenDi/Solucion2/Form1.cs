using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion2
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
        List<int> posicones_imagenes = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 17; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagenes[GenerarImagenes()]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private int GenerarImagenes()
        {
            bool esta = false;
            int numeroX = 0;
            while (!esta) 
            {
                numeroX = random.Next(0, imagenes.Length);
                if (!posicones_imagenes.Contains((int)numeroX))
                {
                    posicones_imagenes.Add((int)numeroX);
                    return numeroX;
                }
            }
            return 0;
        }
    }
}
