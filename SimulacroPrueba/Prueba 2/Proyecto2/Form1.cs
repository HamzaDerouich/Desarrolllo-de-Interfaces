namespace Proyecto2
{
    public partial class Form1 : Form
    {

        Random aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // Encendemos el timer
            tmrNumerosMayoresMenores.Enabled = true;

            // Generamos un número aleatorio entre 1 y 10
            int numero = aleatorio.Next(1, 10);
            labelNumeroMayorMenor.Text = numero.ToString();

            // Si el número es mayor o igual a 5, se agrega a la lista de mayores, si no, a la lista de menores
            if (numero >= 5)
            {
                listBoxMayores.Items.Add(numero.ToString());
            }
            else
            {
                listBoxMenores.Items.Add(numero.ToString());
            }

            // Deshabilitamos el botón para que no se pueda presionar de nuevo mientras el timer está corriendo
            btnEmpezar.Enabled = false;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            // Apagamos el timer 
            tmrNumerosMayoresMenores.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
