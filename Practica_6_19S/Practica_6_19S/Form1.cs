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

namespace Practica_6_19S
{
    public partial class Form1 : Form
    {
        Random aleatorios = new Random();
        System.Windows.Forms.Timer tmrCuentaJuego = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmrOcultarBotones = new System.Windows.Forms.Timer();
        int contadorErros = 0;
        int contadorOcultarBotnes = 5;
        int contadorTiempoJuego = 10;

       static String[] imagenes = {

              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\0.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\1.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\2.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\3.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\4.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\5.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\6.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\7.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\8.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\9.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\10.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\11.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\12.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\13.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\14.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\15.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\16.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\17.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\18.JPG",
              "C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\19.JPG",

            };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Metodos 

            CargarImagenes();
            ConfigurarTmrOcultarBotnes();
            ConfigurarTmrCuentaJuego();

            // Eventos 

            tmrOcultarBotones.Tick += TmrOcultarBotones_Tick;
            tmrCuentaJuego.Tick += TmrCuentaJuego_Tick;

            // Cambiar color pantalla

            switch (contadorTiempoJuego)
            {
                case 5:
                    this.BackColor = Color.Yellow;
                    break;
                case 4:
                case 3:
                case 2:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Black;
                    break;


            }
        }

        private void TmrCuentaJuego_Tick(object sender, EventArgs e)
        {

            label2.Text = contadorTiempoJuego.ToString();
            contadorTiempoJuego--;
            if (contadorTiempoJuego == -1)
            {
                contadorTiempoJuego = 10;
                tmrCuentaJuego.Enabled = false;

                // Metodo colores pantalla 

                

                // Generamos una nueva imagen aleatoria

                button1.Image = Image.FromFile(imagenes[aleatorios.Next(0, imagenes.Length)]);

                // Generar nuevas imagenes

                CargarImagenes() ;

                // Habilitamos el Timmer para ocultar los botones 

                tmrOcultarBotones.Enabled = true;
            }

        }

       

        // Metodo que muestra el contenido de los botones y realiza la la comprobacion de si las imagenes son iguales
        //Atascado preguntar a camacho 
        private void MostrarContenidoBoton()
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {

            }
        }


        // Metodo que configura el timmer del tiempo de juego
        private void ConfigurarTmrCuentaJuego()
        {
         
            tmrCuentaJuego.Enabled = false;
            tmrCuentaJuego.Interval = 1000;
            
        }

        // Metodo que configura el timmer de ocultar los botones 

        private void TmrOcultarBotones_Tick(object sender, EventArgs e)
        {
            
            label1.Text = contadorOcultarBotnes.ToString();
            contadorOcultarBotnes--;
            if(contadorOcultarBotnes == -1)
            {
                contadorOcultarBotnes = 5;
                tmrOcultarBotones.Enabled = false;
                tmrCuentaJuego.Enabled = true ;

                // Metodo Ocultar botones

                OcultarBotones();

            }
        }

        // Metodo que oculta los botones 
        private void OcultarBotones()
        {
            
            foreach ( Control control in flowLayoutPanel2.Controls )
            {
                if ( control is Button btn )
                {

                    btn.Enabled = true;
                    btn.Image = Image.FromFile("C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\manzana.jpg");
                    
                }
            }
            
        }

        // Metodo que configura el timmer que oculta los botones 
        private void ConfigurarTmrOcultarBotnes()
        {
           tmrOcultarBotones.Enabled = true;
           tmrOcultarBotones.Interval = 1000;
        }

        private void CargarImagenes()
        {
            // Los botones van a comenzar deshabilitados 


            // Generamos la imagen que el usuario tiene que adivinar 

            button1.Image = Image.FromFile(imagenes[aleatorios.Next(0, imagenes.Length)]);


            foreach (Control control in flowLayoutPanel2.Controls)
            { 
                if (control is Button btn)
                {
                    btn.Image = Image.FromFile(imagenes[aleatorios.Next(0, imagenes.Length)]);
                    btn.Enabled = true;
                }
            }
        
        }

        // Metodos click 

        private void button2_Click(object sender, EventArgs e)
        {
            

           
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Mostrar la imagen actual del botón
            boton.Image = Image.FromFile(imagenes[aleatorios.Next(0, imagenes.Length)]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}