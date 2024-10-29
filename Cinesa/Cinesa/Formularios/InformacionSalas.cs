using Cinesa.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinesa.Formularios
{
    public partial class InformacionSalas : Form
    {
        ClaseCartelera cartel;
        static List<ClaseCartelera> listado_productos = new List<ClaseCartelera>();
        public InformacionSalas(ClaseCartelera cartel)
        {
            this.cartel = cartel;
            InitializeComponent();
            CargarInfromacionSala();
        }

        private void CargarInfromacionSala()
        {
            ClaseConectar conexion = new ClaseConectar();
            lblSala.Text = cartel.Sala.ToString();
            lblSesion.Text = cartel.Fecha.ToString();
            lblTitulo.Text = cartel.Titulo.ToString();
            ClaseSala sala = conexion.SelectSalas(cartel.Sala);
            int filas = sala.Filas;
            int columnas = sala.Columnas;

            int[][] dimensiones_sala = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                dimensiones_sala[i] = new int[columnas];
            }

            // Creamos el panel que contendra los botones 

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill; 
            flowLayoutPanel.AutoScroll = true; 
            flowLayoutPanel.WrapContents = true; 
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight; 
            flowLayoutPanel.Padding = new Padding(10); 
            flowLayoutPanel.BackColor = Color.White; 

            panelContendor.Controls.Add(flowLayoutPanel);

            // Crear botones para cada posición en la matriz y añadirlos a un contenedor (como un Panel o Form)

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button button = new Button();
                    button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    button.Text = $"Fila{i + 1} / Columna{j + 1}";
                    button.Width = 200;
                    button.Height = 80;
                    button.Font = new Font("Arial", 10, FontStyle.Bold); 
                    button.BackColor = Color.Blue; 
                    button.ForeColor = Color.White; 
                    button.FlatStyle = FlatStyle.Flat; 
                    button.FlatAppearance.BorderSize = 0;

                    button.Tag = cartel ;
                    button.Click += Button_Click;
                    

                    button.MinimumSize = new Size(120, 40);


                    flowLayoutPanel.Controls.Add(button);

                }
            }

            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ClaseCartelera cartel = (ClaseCartelera)button.Tag;


            if( button.BackColor == Color.Blue )
            {
                button.BackColor = Color.Red;
                listado_productos.Add(cartel);
            }
            else
            {
                button.BackColor = Color.Blue;
                listado_productos.Remove(cartel);
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cesta cesta = new Cesta(listado_productos);
            cesta.Show();
        }
    }
}
