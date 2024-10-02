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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cartelera
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        static CrudCartelera acceso = new CrudCartelera();
        static List<Cartelera> carteleras = acceso.SelectCartelera();
        int siguiente = 0;

        public Form1()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            Cartelera cartel = carteleras.First();

            // Mostramos la información de la pelicula
            MostrarDatos(cartel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            siguiente++;
            foreach (Cartelera control in carteleras)
            {
                if (siguiente > carteleras.Count)
                {
                    siguiente = 0;
                }
                else
                {
                    if (control.Indice == siguiente)
                    {
                        MostrarDatos(control);
                    }
                }
            }
        }

        private void MostrarDatos(Cartelera control)
        {
            string[] datos_titulo = control.Sesion.Split('-');
            lblTitulo.Text = control.Titulo;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            label3.Text = datos_titulo[3]; ;
            label4.Text = datos_titulo[1] + "-" + datos_titulo[1] + "-" + datos_titulo[2];
            label1.Text = control.Sala.ToString();

            // Mostramos la imgen en el picture box 
            MemoryStream stream = new MemoryStream(control.Cartel);
            Bitmap bmp = new Bitmap(stream);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siguiente--;
            foreach (Cartelera control in carteleras)
            {
                if( siguiente > carteleras.Count)
                {
                    siguiente = 0;


                }
                else
                {
                    if (control.Indice == siguiente)
                    {
                        MostrarDatos(control);
                    }
                }
               
            }
        }
    }
}