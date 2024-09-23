using System.Windows.Forms;

namespace Practica4_19S
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerNivel0 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerNivel1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerNivel2 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer colorBoton0 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer colorBoton1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer colorBoton2 = new System.Windows.Forms.Timer();


        System.Windows.Forms.Timer timerTiempoPartida = new System.Windows.Forms.Timer();
        Random aleatorios = new Random();
        int contador = 30;
        int contadorPuntos = 0;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AñadirElementosLista();    
        }

        // Metodo que añade los niveles a la lista

        private void AñadirElementosLista()
        {
            comboBox1.Items.Add("Nivel 1 :)");
            comboBox1.Items.Add("Nivel 2 :[|]");
            comboBox1.Items.Add("Nivel 3 ;(");
        }

        // Metodo que gestiona las propiedades del timmer que se encarga de limpiar los botones del nivel 2 = poner los botones de color azul

        private void ColorBoton2_Tick(object? sender, EventArgs e)
        {
            colorBoton2.Enabled = false;
            colorBoton2.Interval = 500;
            LimpiarBotones();
        }

        // Metodo que gestiona las propiedades del timmer que se encarga de limpiar los botones del nivel 1 = poner los botones de color azul

        private void ColorBoton0_Tick(object? sender, EventArgs e)
        {
            colorBoton0.Enabled = false;
            colorBoton0.Interval = 1000;
            LimpiarBotones();
        }


        private void TimerTiempoPartida_Tick(object? sender, EventArgs e)
        {
                label3.Text = contador.ToString();
                contador--;
                if (contador == 01)
                {
                 
                timerTiempoPartida.Enabled = false; // Para la partida 

                MessageBox.Show("Puntos totales conseguidos: " + contadorPuntos );
                    DialogResult resultado = MessageBox.Show("¿Otra partida?" , "No te lo pienses venga!!" ,MessageBoxButtons.YesNo , MessageBoxIcon.Question );
                    if( resultado == DialogResult.Yes)
                {
                    contador = 30;
                    label3.Text="0";
                    comboBox1.Enabled = true;
                }
                else
                {
                    Close();
                }
                     
                }
        }

        private void TemporizadorTiempoPartidaConf()
        {
            timerTiempoPartida.Enabled = false;
            timerTiempoPartida.Interval = 1000;
        }

        private void ColorBoton1_Tick(object? sender, EventArgs e)
        {
            colorBoton1.Enabled = false;
            colorBoton1.Interval = 1000;
            LimpiarBotones();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventosTimmerLimpiarBotones();
            EventosTimmer();
            ConfiguracionTemporizadores();
            EventoTiempoPartida();
           
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    TemporizadorUnoConf();
                    break;
                case 1:
                    TemporizadorDosConf();
                    break;
                case 2:
                    TemporizadorTresConf();
                    break;
            }

            comboBox1.Enabled = false;
        }

        // Metodo que Gestiona los eventos del timmer evento partida

        private void EventoTiempoPartida()
        {

            TemporizadorTiempoPartidaConf();
            
            timerTiempoPartida.Tick -= TimerTiempoPartida_Tick;
            timerTiempoPartida.Tick += TimerTiempoPartida_Tick;
            timerTiempoPartida.Start();


        }

        // Metodo que gestion los eventos de los timmer de los niveles 

        private void EventosTimmer()
        {
            
            // Desesucribimos del evento para evitar acomulaciones
            timerNivel0.Tick -= TimerNivel0_Tick;
            timerNivel1.Tick -= TimerNivel1_Tick;
            timerNivel2.Tick -= TimerNivel2_Tick;

            // Nos suscribimos al evento de nuevo 
            timerNivel0.Tick += TimerNivel0_Tick;
            timerNivel1.Tick += TimerNivel1_Tick;
            timerNivel2.Tick += TimerNivel2_Tick;
        }

        // Metodo que gestiona el temporizador tres = del nivel 3 

        private void TemporizadorTresConf()
        {
            timerNivel2.Start();
            timerNivel1.Stop();
            timerNivel0.Stop();
            
        }

        // Metodo que gestiona el temporizador dos = del nivel 2

        private void TemporizadorDosConf()
        {
            timerNivel1.Start();
            timerNivel2.Stop();
            timerNivel0.Stop();
        }

        // Metodo que gestiona el temporizador uno = del nivel 1

        private void TemporizadorUnoConf()
        {
            timerNivel0.Start();
            timerNivel1.Stop();
            timerNivel2.Stop();
        }

        // Metodo que gestiona los eventos del timmer de limpiar los botones

        private void EventosTimmerLimpiarBotones()
        {
            // Desuscribimos eventos anteriores para evitar acumulación
            colorBoton0.Tick -= ColorBoton0_Tick;
            colorBoton1.Tick -= ColorBoton1_Tick;
            colorBoton2.Tick -= ColorBoton2_Tick;

            // Suscribimos de nuevo los eventos 

            colorBoton0.Tick += ColorBoton0_Tick;
            colorBoton1.Tick += ColorBoton1_Tick;
            colorBoton2.Tick += ColorBoton2_Tick;
        }

        // Metodo que establece las propiedades de los timmers de los niveles

        private void ConfiguracionTemporizadores()
        {
            // Configuracion Timmer 1
            
            timerNivel0.Enabled = false;
            timerNivel0.Interval = 3000;

            // Configuracion Timmer 2
            timerNivel1.Enabled = false;
            timerNivel1.Interval = 1000;

            // Configuracion Timmer 3
            timerNivel2.Enabled = false;
            timerNivel2.Interval = 500;
        }

        // Metodo configura el generado y el limpiado de los botones según el nivel en este caso el 1

        private void TimerNivel2_Tick(object? sender, EventArgs e)
        {
            GenerarColores();
            colorBoton2.Start();
            colorBoton1.Stop();
            colorBoton0.Stop();
        }

        // Metodo configura el generado y el limpiado de los botones según el nivel en este caso el 2

        private void TimerNivel0_Tick(object? sender, EventArgs e)
        {
            GenerarColores();
            colorBoton0.Start();
            colorBoton1.Stop();
            colorBoton2.Stop();
        }

        // Metodo configura el generado y el limpiado de los botones según el nivel en este caso el 3

        private void TimerNivel1_Tick(object? sender, EventArgs e)
        {
            GenerarColores();
            colorBoton1.Start();
            colorBoton2.Stop();
            colorBoton0.Stop();

        }

        // Metodo click que comprueba si a hacertado el usario 
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Red)
            {
                label2.Text = contadorPuntos.ToString();
                contadorPuntos++;
            }
            else
            {
                label2.Text = contadorPuntos.ToString();
                contadorPuntos--;
            }
        }
           
        // Metodo que cambia el color del boton de forma aleatoria
        private void GenerarColores()
        {
            Control[] controls = panel1.Controls.Cast<Control>().ToArray();
            Control control = controls[aleatorios.Next(0, controls.Length)];
            control.BackColor = Color.Red;
        }

        // Metodo que limpia los botones 
        private void LimpiarBotones()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.Blue;
                }
            }
        }

    }
}
