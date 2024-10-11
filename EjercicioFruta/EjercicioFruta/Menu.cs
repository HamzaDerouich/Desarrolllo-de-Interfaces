using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFruta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void consultarCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
        }

        private void consultarCestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cesta cesta = new Cesta();
            cesta.Show();
        }
    }
}
