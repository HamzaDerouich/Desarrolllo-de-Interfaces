namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        public Form1()
        {
            InitializeComponent();
            textBox.Select();

           

        }

        // Metodo que arranca el timer y deshabilita el boton de restar 

        private void btnBuscarNumero(object sender, EventArgs e)
        {
            timerRandom.Enabled = true;
            btnReset.Enabled = false;





        }

        // Genera un número aleatorio del uno al 100 y comprueba si es igual al introducido por el usuario 
        // Apaga el timmer 

        private void timerRandom_Tick(object sender, EventArgs e)
        {

            int numeroX = aleatorio.Next(1,100);
            int numeroY = 0 ;
            Boolean iguales = true;
            txtRandomLabel.Text = numeroX.ToString(); // pasa los valores a string 
            txtContadorLabel.Text = numeroX.ToString();
            

            if (numeroX == Convert.ToInt16(textBox.Text)) // Convierte el string a número 
            {

                MessageBox.Show("Encotrado: " + numeroX); // muestra el mensaje

               
             
                timerRandom.Enabled = false; // apaga el timer 

                
            }
           

           



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRandom.Enabled = false;

        }



        // metodo textBoxKeyPress valida si es un número 

        private void textBoxKeyPrees(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Metodo textBoxKeyUp valida al pulsar enter que es un número menor que 100

        private void textBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Convert.ToInt16(textBox.Text) < 100  )
            {
                btnRandomMenor100.Enabled = true;
            }
            else
            {
                btnRandomMenor100.Enabled = false;
            }
        }


        // Metodo reset, deja los valores del text en el punto incial, y deshabiita el btn buscar 

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox.Select();
            btnRandomMenor100.Enabled = false;
        }
    }
}
