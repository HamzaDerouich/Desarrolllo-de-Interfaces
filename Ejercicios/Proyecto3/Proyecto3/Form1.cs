namespace Proyecto3
{
    public partial class Form1 : Form
    {

        Random aleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarkeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Convert.ToInt16(textBox1.Text) <= 1000)
                {
                    btnBuscar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El número excede el limite. Gracias!!");
                }

            }
        }



        private void BtnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void BtnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
