namespace BotonesProgramatically
{
    public partial class Form1 : Form
    {

        Random aleatorios = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }

        private void txtBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Convert.ToInt16(textBoxNumeroBotones.Text) > 50)
                {

                    MessageBox.Show("Demasiados cuadros!!");
                    textBoxNumeroBotones.Text = "";

                }
                else
                {


                    btnColoresRandom.Enabled = true;
                    btnNumerosRandom.Enabled = true;
                    btnReset.Enabled = true;
                    textBoxNumeroBotones.Enabled = false;

                }


            }

        }

        private void txtBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que quieres salir??", "Programatically 1", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxNumeroBotones.Text = "";
            textBoxNumeroBotones.Enabled = true;
            btnColoresRandom.Enabled = false;
            btnNumerosRandom.Enabled = false;
            btnReset.Enabled = false;
            LimpiarGroupBox();



        }

        private void btnColoresRandom_Click(object sender, EventArgs e)
        {

            // GrupBox

            foreach (Control control in grpBox.Controls) 
            {
                control.BackColor = Color.FromArgb( ( aleatorios.Next( 0,256 )) , aleatorios.Next(0, 256), aleatorios.Next(0, 256), aleatorios.Next(0, 256));
            }

            // Flow Layout Panel 

            foreach (Control control in flpanel.Controls)
            {
                control.BackColor = Color.FromArgb((aleatorios.Next(0, 256)), aleatorios.Next(0, 256), aleatorios.Next(0, 256), aleatorios.Next(0, 256));
            }


        }

        private void btnNumerosRandom_Click(object sender, EventArgs e)
        {
           

            // GrupBox

            foreach (Control control in grpBox.Controls)
            {
                control.Text = Convert.ToString(aleatorios.Next(1, 100));
               
            }

            // Flow Layout 

            // Limpiamos antes de añdir los botenes 

            flpanel.Controls.Clear();


            for (int i = 0; i < Convert.ToUInt16(textBoxNumeroBotones.Text); i++)
            {
                Button button = new Button();
                button.Text = Convert.ToString(aleatorios.Next(1, 100));
                flpanel.Controls.Add(button);

            }


        }

        private void LimpiarGroupBox()
        {
            // Limpia el GroupBox

            foreach (Control control in grpBox.Controls)
            {
                control.Text = "";
            }

            // Limpiar de elementos el FlowLayoutPanel


        }

        private void button19_Click(object sender, EventArgs e)
        {
          Button btn = (Button) sender ;
          MessageBox.Show(btn.Text);
        }
    }
}
