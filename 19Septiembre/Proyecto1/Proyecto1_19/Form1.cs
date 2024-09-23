namespace Proyecto1_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Elementos formulario

    static System.Windows.Forms.Timer tmrCuentaAtras = new System.Windows.Forms.Timer();
        Button btn1 = new Button();
        Button btn2 = new Button();
        ComboBox cmb = new ComboBox();
        Label titulo = new Label();
        Label salir = new Label();
        Label contador = new Label();
        Font font = new Font("Times New Roman", 20.0f, FontStyle.Bold);
        int contadorCuentaAtras = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Estilos formulario

            EstilosForm();
            EstilosBotones();
            EstilosEtiquetasLabel();
            EstilosComBox();
            ElementosCombBox();
            ConfiguracionTimer();

            // Evento Formulario 

            this.KeyPreview = true;
            this.KeyUp += Form1_KeyUp;
            cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            

        }

        private void Cmb_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Color color = (Color) cmb.SelectedItem;
            this.BackColor = color;  
        }

        private void ElementosCombBox()
        {
            Color[] color = { Color.Red, Color.Green, Color.Blue, Color.AliceBlue, Color.Azure };
            foreach (var c in color)
            {
                cmb.Items.Add(c);
            }
        }

        private void ConfiguracionTimer()
        {

            tmrCuentaAtras.Tick += new EventHandler(Btn1_Click);
            tmrCuentaAtras.Interval = 1000;


        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
           DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir!!", "Ventana Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

           if( e.KeyCode == Keys.Escape)
            {
                if( resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

      

        private void EstilosComBox()
        {
          
            cmb.SetBounds(300, 200, 200, 100);
            this.Controls.Add(cmb);
        }

        private void EstilosEtiquetasLabel()
        {
          

           titulo.Text = "Diseño 0. Todo programtically";
           titulo.Font = font;
           titulo.SetBounds(10,20, 600, 50);


            salir.Text = "Para salir pulse la teclas ESC";
            salir.Font = font;
            salir.SetBounds(10, 80, 600, 100);

            contador.Text = "10";
            contador.Font = font;
            contador.SetBounds(380, 300, 100, 100);



            this.Controls.Add(titulo);
            this.Controls.Add(salir);
            this.Controls.Add(contador);




        }

        private void EstilosForm()
        {
            this.BackColor = Color.DarkOrange;
            
        }

        private void EstilosBotones()
        {

            btn1.Text = "Empezar";
            btn2.Text = "Pausar";
            btn1.SetBounds(600, 20, 80, 50);
            btn1.BackColor = Color.LightGray;
            btn2.SetBounds(700, 20, 80, 50);
            btn2.BackColor = Color.LightGray;

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);

            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;

        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            tmrCuentaAtras.Enabled = false;
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            tmrCuentaAtras.Enabled = true;
            contador.Text = contadorCuentaAtras.ToString();
            if( !(contadorCuentaAtras == 0))
            {
                contadorCuentaAtras--;
            }
            else
            {
                contadorCuentaAtras = 10;
                tmrCuentaAtras.Enabled = false;
            }

        }
    }
}
