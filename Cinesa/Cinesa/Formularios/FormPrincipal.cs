using Cinesa.Clases;
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
    public partial class FormPrincipal : Form
    {
        static ClaseConectar conexion = new ClaseConectar();
        List<ClaseCartelera> listado_carteleras = conexion.SelectCartelera();
        public FormPrincipal()
        {
            InitializeComponent();
            CargarCarteles();
        }

        public void CargarCarteles()
        {
            List<string> aux = new List<string>();
            List<ClaseCartelera> listado_cartelara_no_repetido = new List<ClaseCartelera>();
            MessageBox.Show(listado_carteleras.Count.ToString());  
         
            foreach( ClaseCartelera a in listado_carteleras )
            {
                if(!ExisteCartelera(a.Titulo))
                {
                    
                   if( a != null )
                    {
                        // Panel contenedor

                        Panel panel = new Panel();
                        panel.Width = 200;
                        panel.Height = 250;
                        panel.BorderStyle = BorderStyle.Fixed3D;
                        panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        panel.BackColor = Color.White;

                        // Imagen de la película

                        MemoryStream ms = new MemoryStream(a.Cartel);
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Height = 220;
                        pictureBox.Width = 200;
                        pictureBox.Dock = DockStyle.Top;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        pictureBox.Tag = a;
                        pictureBox.Click += PictureBox_Click;

                        // Label del título

                        Label label = new Label();
                        label.Text = a.Titulo.ToUpper();
                        //label.Font = new Font("Arial" , 10 , FontStyle.Bold); 
                        label.AutoSize = true;
                        label.ForeColor = Color.Black; 
                        label.TextAlign = ContentAlignment.MiddleCenter; 
                        label.Dock = DockStyle.Bottom;
                        label.Padding = new Padding(0, 5, 0, 5);

                        // Añadimos los controles al panel

                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);

                        flPanel.Controls.Add(panel);    
                    }

                }
            }

           

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
           PictureBox pictureBox = (PictureBox)sender;
           ClaseCartelera cartelera = (ClaseCartelera) pictureBox.Tag;

            InformacionPeliculas info = new InformacionPeliculas(cartelera);
            info.Show();

        }

        List<string> listado_titulos = new List<string>();
        private bool ExisteCartelera(string titulo)
        {
            foreach ( string a in listado_titulos )
            {
                if( a.Equals(titulo) )
                {
                   return true;
                }
               
            }

            listado_titulos.Add(titulo);
            return false;
        }
    }
}
