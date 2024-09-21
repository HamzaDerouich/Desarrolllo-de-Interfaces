using System.Globalization;

namespace Prueba3
{
    public partial class Form1 : Form
    {

        Random aleatorio = new Random();
        int contador = 0;


        public Form1()
        {
            InitializeComponent();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timerNumeroRandom.Enabled = true;
            int numeroAleatorio = aleatorio.Next(1, 100);
            int numeroTextBox = Convert.ToInt16(textBox1.Text);



            label3.Text = numeroAleatorio.ToString();
            label2.Text = contador.ToString();

            if (numeroAleatorio != numeroTextBox)
            {
                contador++;
            }
            else
            {
                timerNumeroRandom.Enabled = false;
                button1.Enabled = false;
                textBox1.Text = "";
                MessageBox.Show("El número de intentos que se han necesitado son:" + contador);
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }


        private void TxtLabelKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void TxtLabelKeyUp(object sender, KeyEventArgs e)
        {

            String txtBox = Convert.ToString(textBox1.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (!(Convert.ToInt16(txtBox) > 1000))
                {
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Has excedido el limite");
                    button1.Enabled=false;
                }

            }

        }

       
    }
}
