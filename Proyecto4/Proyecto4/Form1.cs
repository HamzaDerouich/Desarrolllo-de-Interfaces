namespace Proyecto4
{
    public partial class Form1 : Form
    {
        Random aleatorios = new Random();
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAleatorios_Click(object sender, EventArgs e)
        {
            foreach (Control control in grpAleatorios.Controls)
            {
                control.Text = Convert.ToString(aleatorios.Next(1, 100));
            }
        }

        private void grpAleatorios_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label = (Label) sender ;
            MessageBox.Show(" Valor : " + label.Text);
        }
    }
}
