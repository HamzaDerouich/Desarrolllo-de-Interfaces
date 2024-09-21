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
           

            foreach ( Control control in grbAleatorios.Controls )
            {
              control.Text = Convert.ToString(aleatorios.Next(1,100));
              grbAleatorios.Controls.Add( control );
            }

        }

        private void grbAleatorios_Enter(object sender, EventArgs e)
        {

        }
    }
}
