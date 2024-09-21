using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_1
{
    public partial class Form1 : Form
    {
        Random aleatorio  = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {

            // Limpiamos el FlouLayout panel cada vez que generemos los aleatorios 

            flowLayoutPanel1.Controls.Clear();

            label1.Text = Convert.ToString(aleatorio.Next(1,1000));
            for (int i = 0; i < 10; i++) 
            {
                Label lbl = new Label();
                lbl.Text = Convert.ToString(aleatorio.Next(1, 1000));
                flowLayoutPanel1.Controls.Add(lbl);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          DialogResult resultado =  MessageBox.Show( " ¿Seguro que quieres salir?" , "Programtically" , MessageBoxButtons.YesNoCancel , MessageBoxIcon.Question );
            if (resultado == DialogResult.Yes)
            { 
                Close();
            }


        }
    }
}
