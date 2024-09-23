using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6_19S
{
    public partial class Form1 : Form
    {
        
        Random aleatorios = new Random();
        System.Windows.Forms.Timer timmerOcultar = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timmerTiempoPartida = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timmerOcultarImagen = new System.Windows.Forms.Timer();


        int contadorOcultar = 5;
        int contadorTiempoPartida = 10;
        int contadorAciertos = 0;

        static string[] imagenes =
        {
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
            CargarImagenes();
            ConfOcultarBotones();
            ConfiguracionTimerTiempoPartida();
            ConfOcultarImagen();
            
        }

        // Metodo que configura el timmer del timpo de partidad 

        private void ConfiguracionTimerTiempoPartida()
        {
            timmerTiempoPartida.Tick -= TimmerTiempoPartida_Tick;
            timmerTiempoPartida.Tick += TimmerTiempoPartida_Tick;
            timmerTiempoPartida.Enabled = false;
            timmerTiempoPartida.Interval = 1000;
        }

        // Timmer del tiempo de partida. Algoritmo que controla la Actualización y la generación de imagenes y
        // label de la cuenta de atrás.

        private void TimmerTiempoPartida_Tick(object sender, EventArgs e)
        {
            timmerOcultarImagen.Start();
            label2.Text = contadorTiempoPartida.ToString();
            contadorTiempoPartida--;
            if (contadorTiempoPartida < 0)
            {
                timmerOcultarImagen.Stop();
                timmerTiempoPartida.Stop();
                timmerOcultar.Start();
                GenerarNuevasImagenes();
                contadorTiempoPartida = 10;
            }
        }

        // Metodo asociado al timmer de tiempo de partida encargado de generar nuevas imagenes 

        private void GenerarNuevasImagenes()
        {
            String rutaImagenAveriguar = imagenes[aleatorios.Next(0, imagenes.Length)];
            button1.Image = Image.FromFile(rutaImagenAveriguar);
            button1.Tag = rutaImagenAveriguar;
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is Button button)
                {
                    String rutaImagen = imagenes[aleatorios.Next(0, imagenes.Length)];
                    Image imagen = Image.FromFile(rutaImagen);
                    button.Image = imagen;
                    button.Tag = rutaImagen;
                    button.Enabled = false;
                }
            }
        }

        // Evento button click ( el evento se genera en el metodo cargar imagenes ) , se encarga de comprobar los aciertos y los errores del usuario 
        
        private void Button_Click(object sender, EventArgs e)
        {
            label3.Text = contadorAciertos.ToString();
            Button button = (Button)sender;
            string rutaImagen = button.Tag.ToString();
            button.Image = Image.FromFile(rutaImagen);
            button.AutoSize = true;
            if (button.Tag.Equals(button1.Tag))
            {
               
                contadorAciertos++;
            }
            else
            {
                contadorAciertos--;
            }
        }

        // Metodo de encargar los botones con las imagenes ( las rutas de las imagenes se encuentrar en el contenedor de imagenes) 

        private void CargarImagenes()
        {
            ConfiguracionButtonImagenAveriguar();

            for (int i = 0; i < 42; i++)
            {
                CrearButtonImageFlPanel();

            }
        }

        // Configuracion de los botones que se crean en el metodo cargar imagenes
        // La asiganacion de la imgaen  y sus eventos 

        private void CrearButtonImageFlPanel()
        {
            Button button = new Button();
            String rutaimagen = imagenes[aleatorios.Next(0, imagenes.Length)];
            button.Image = Image.FromFile(rutaimagen);
            button.Tag = rutaimagen;
            button.AutoSize = true;
            button.Enabled = false;
            button.Click += Button_Click;
            flowLayoutPanel2.Controls.Add(button);
        }

        // Configuracion del timmer ocultar imagenes encargado de ocultar las imagenes 
        // En el se asignan sus parametros y sus respectivos eventos 


        private void ConfOcultarImagen()
        {
            timmerOcultarImagen.Tick -= TimmerOcultarImagen_Tick;
            timmerOcultarImagen.Tick += TimmerOcultarImagen_Tick;
            timmerOcultarImagen.Enabled = false;
            timmerOcultarImagen.Interval = 500;
        }

        // Timmer ocultar imagen que lleva asociado un metodo encargado de ocultar los botones

        private void TimmerOcultarImagen_Tick(object sender, EventArgs e)
        {
            Ocultarbotones();
        }

        // Configuracion del button de la imagen que tiene que averiguar el usuario
        // En él se asigan sus parametros y la imagén 

        private void ConfiguracionButtonImagenAveriguar()
        {
            String rutaimagen = imagenes[aleatorios.Next(0, imagenes.Length)];
            button1.Image = Image.FromFile(rutaimagen);
            button1.Tag = rutaimagen;
            button1.Text = "";
            button1.AutoSize = true;
        }


        // Configuracion del timmer ocultar los botones ( Sobreponer la imagen de la manzana ) imagenes encargado de ocultar las imagenes 
        // En el se asignan sus parametros y sus respectivos eventos 

        private void ConfOcultarBotones()
        {
            timmerOcultar.Tick -= TimmerOcultar_Tick;
            timmerOcultar.Tick += TimmerOcultar_Tick;
            timmerOcultar.Enabled = true;
            timmerOcultar.Interval = 1000;
        }


        // Evento encargado de controlar el timmer del tiempo que tiene el usuario para visualizar las imagenes 
        private void TimmerOcultar_Tick(object sender, EventArgs e)
        { 
            timmerOcultar.Start();
            label1.Text = contadorOcultar.ToString();
            contadorOcultar--;
            if (contadorOcultar < 0)
            {
                timmerTiempoPartida.Start();
                timmerOcultar.Stop();
                contadorOcultar = 5;
            }

        }

        // Metodo Ocultar botones encargado de ocultar las imagenes ( sobreponer la manzana ) 

        private void Ocultarbotones()
        {
            foreach (Control  control in flowLayoutPanel2.Controls)
            {
                if( control is Button button)
                {

                    button.Image = Image.FromFile("C:\\Users\\Usuario\\source\\repos\\Practica_6_19S\\Practica_6_19S\\imagenes\\manzana.JPG");
                    button.AutoSize = true;
                    button.Enabled = true;
                    
                }
            }
        }
    }

}
