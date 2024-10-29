using Cinesa.Clases;
using Cinesa.Formularios;
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

namespace Cinesa
{
    public partial class InformacionPeliculas : Form
    {
        ClaseCartelera cartelera;
        List<ClaseCartelera> claseCartes;
        public InformacionPeliculas(ClaseCartelera cartel)
        {
           
            this.cartelera = cartel;
            InitializeComponent();
            CargarInformacionCartel();
        }

        private void CargarInformacionCartel()
        {

           ClaseConectar conexion = new ClaseConectar();
           List<ClaseCartel> informacion_cartel = conexion.SelectCartel(cartelera.Id_pelicula);
           MemoryStream ms = new MemoryStream(cartelera.Cartel);
           ImagenPelicula.Image = Image.FromStream(ms);
           dataGridView1.DataSource = informacion_cartel;

            foreach (ClaseCartel c in informacion_cartel)
            {
                Button button = new Button();
                button.Text = c.Fecha.ToString("dd MMM yyyy"); // Mostrar la fecha en formato día mes año

                // Tamaño y estilo del botón
                button.Width = 120;
                button.Height = 40;
                button.Font = new Font("Arial", 10, FontStyle.Bold); // Fuente y estilo
                button.BackColor = Color.FromArgb(52, 152, 219); // Color de fondo (azul claro)
                button.ForeColor = Color.White; // Color del texto (blanco)
                button.FlatStyle = FlatStyle.Flat; // Estilo plano para el borde
                button.FlatAppearance.BorderSize = 0; // Sin borde
                button.Tag = c;
                button.Click += Button_Click;

                flp.Controls.Add(button);
            }



        }

        private void Button_Click(object sender, EventArgs e)
        {
           ClaseConectar conexion = new ClaseConectar();
           Button button = (Button)sender;
           ClaseCartel c = (ClaseCartel)button.Tag;

            ClaseCartelera c1 = conexion.SelectInfoCartel(c.Id_pelicula, c.Sala);

            InformacionSalas info = new InformacionSalas(c1);
            info.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
