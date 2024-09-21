namespace Practica2_19S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AñadirElementosCmb1();
            AñadirElementosCmb2();
        }

        private void AñadirElementosCmb2()
        {
            comboBox2.Items.Add("Números");
            comboBox2.Items.Add("Imagenes");
            comboBox2.Items.Add("Colores");

            // Eventos CombBox

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
        }

        private void ComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string tipo = comboBox2.Text;
            string numero = comboBox1.Text;

            

            Random aleatorio = new Random();
            Color[] colores = { Color.AliceBlue, Color.Azure , Color.BlueViolet , Color.BurlyWood };
            String[] imagenes = {
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\1.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\0.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\10.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\14.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\2.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\17.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\8.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\13.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\5.JPG",
                "C:\\Users\\Usuario\\source\\repos\\Practica2_19S\\Practica2_19S\\imagenes\\2.JPG"
            };
            
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Convert.ToInt16(numero); i++)
            {
                Button bt = new Button();
                bt.Size = new Size(40, 40);
                if (tipo.Equals("Números"))
                {
                    bt.Text = Convert.ToString( aleatorio.Next(1,100));
                    flowLayoutPanel1.Controls.Add(bt);
                }
                else if (tipo.Equals("Colores"))
                {
                    Color c = colores[aleatorio.Next(0, colores.Length)];
                    bt.BackColor = c;
                    flowLayoutPanel1.Controls.Add(bt);
                }
                else if( tipo.Equals("Imagenes") )
                {
                    Button image = new Button();
                    String ruta = imagenes[aleatorio.Next(0, imagenes.Length)];
                    image.Image = Image.FromFile(ruta);
                    image.Size = new Size(100, 100);
                    flowLayoutPanel1.Controls.Add(image);
                } else
                {
                    
                }

            }
        }

        private void AñadirElementosCmb1()
        {
            for (int i = 0; i < 50; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
              "¿Seguro que quieres salir?", "Ventana Salir" , MessageBoxButtons.YesNoCancel , MessageBoxIcon.Exclamation  );
            if ( resultado == DialogResult.Yes )
            {
                Close();
            }
        }
    }
}
