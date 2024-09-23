namespace Proyecto5
{
    public partial class Form1 : Form
    {
        Random aleatorios = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void bntRandoms_Click(object sender, EventArgs e)
        {
            foreach (Control control in grbAleatorios.Controls)
            {
                if (control is Label label)
                {
                    label.Text = aleatorios.Next(0, 50).ToString();
                }
            }
        }

        private void grbAleatorios_Enter(object sender, EventArgs e)
        {

        }
    }
}
