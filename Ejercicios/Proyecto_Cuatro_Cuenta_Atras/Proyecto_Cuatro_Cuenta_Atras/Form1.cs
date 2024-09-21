namespace Proyecto_Cuatro_Cuenta_Atras
{
    public partial class Form1 : Form
    {
        int contador = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1Inicio_Click(object sender, EventArgs e)
        {

           tmrInicio.Enabled = true;
           btnCuentaAtras.Visible = true;

           btnCuentaAtras.Text= contador.ToString();

            contador--;

            switch (contador)
            {
                case -1:
                    tmrInicio.Enabled= false;
                    btnCuentaAtras.Visible = false;
                    contador = 10;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                    btnCuentaAtras.BackColor = Color.Yellow;
                    break;
                case 5:
                case 4:
                    btnCuentaAtras .BackColor = Color.Blue;
                    break;
                case 2:
                case 1:
                case 0:
                    btnCuentaAtras.BackColor = Color.Red;
                    break;


            }

        }
    }
}
