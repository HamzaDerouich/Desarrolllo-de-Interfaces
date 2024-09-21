namespace Practica3_19S
{
    public partial class Form1 : Form
    {
        Color[] color = { Color.Red, Color.Green, Color.Blue };
        Random aleatorios = new Random();
        System.Windows.Forms.Timer timerCambioPantalla = new System.Windows.Forms.Timer();
        int Contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Metodo que genera los colores y da cominezo al juego
            EmpezarJuego();
            ConfiguracionTimerCambioDePantalla();

            // Eventos

            timerCambioPantalla.Tick += TimerCambioPantalla_Tick; ;
        }

        private void ConfiguracionTimerCambioDePantalla()
        {
          
            timerCambioPantalla.Enabled = true;
            timerCambioPantalla.Interval = 1000;


        }

        private void TimerCambioPantalla_Tick(object? sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void EmpezarJuego()
        {
            DialogResult resultado = MessageBox.Show(" [Rojo = 5 ] - [ Verde = 10 ] - [ Azul = 20 ] - [Error = -100]  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button button = new Button();
            button.BackColor = color[aleatorios.Next(0, color.Length)];
            button.Size = new Size(100, 100);
            button.Click += Button_Click;

            int xPos = aleatorios.Next(0, panel1.Width - button.Width);
            int yPos = aleatorios.Next(0, panel1.Height - button.Height);

            button.Location = new Point(xPos, yPos);


            panel1.Controls.Add(button);

        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Red)
            {
                btn.Text = "5";
                Contador += 5;
                panel1.Controls.Remove(btn);

            }
            else if (btn.BackColor == Color.Green)
            {
                btn.Text = "10";
                Contador += 10;
                panel1.Controls.Remove(btn);


            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.Text = "20";
                Contador += 20;
                panel1.Controls.Remove(btn);

            }

            label1.Text = Contador.ToString();


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Contador -= 100;
            panel1.BackColor = Color.Red;
           
        }
    }
}

