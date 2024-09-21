namespace Prueba3_1_octubre
{


    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timmerNumeros = new System.Windows.Forms.Timer();
        Random aleatorios = new Random();
        int contadorAcertados = 0;
        public Form1()
        {
            InitializeComponent();
            ConfTimmerNumeros();
            LLenarNumerosGroupBox();
            
        }


        // Metodo que rellena los botones del group box

        private void LLenarNumerosGroupBox()
        {
            txtAveriguar.Text = aleatorios.Next(1, 25).ToString();
            foreach (Control control in ContenedorBotones.Controls)
            {
                if (control is Button button)
                {
                    button.Text = aleatorios.Next(1, 100).ToString();
                }
            }
        }

        // Evento tick que actualiza los números

        private void TimmerNumeros_Tick(object? sender, EventArgs e)
        {
            timmerNumeros.Start();
            ActualizarNuemerosLabel();

        }

        // Metodo que actualiza los botones

        private void ActualizarNuemerosLabel()
        {
            txtAveriguar.Text = aleatorios.Next(1, 25).ToString();
            foreach (Control control in ContenedorBotones.Controls)
            {
                if (control is Button button)
                {
                    button.Text = aleatorios.Next(1, 25).ToString();
                }
            }
        }

        // Configuracion del timmer que actualiza los botones
        private void ConfTimmerNumeros()
        {
            timmerNumeros.Tick += TimmerNumeros_Tick;
            timmerNumeros.Enabled = false;
            timmerNumeros.Interval = 5000;
        }

        // Metodo que realiza la comprobacion de los números

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

          

            string numeroLabel = txtAveriguar.Text.ToString();
            string numeroButton = button.Text.ToString();

            int numero1 = Convert.ToInt16(numeroLabel);
            int numero2 = Convert.ToInt16(numeroButton);

            if (numero1 == numero2)
            {
                contadorAcertados++;
                txtContador.Text = contadorAcertados.ToString();
            }
        }


        // Metodo que incia el timmer 
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ConfTimmerNumeros();
            timmerNumeros.Enabled = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
