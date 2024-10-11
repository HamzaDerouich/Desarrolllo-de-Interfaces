using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFruta
{
    public partial class Login : Form
    {
        bool usuario_correcto = false;
        bool contraseña_correcta = false;
        static CRUD acceso = new CRUD("Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true");
        List<Usuario> listado_usuarios = acceso.ObtenerUsuarios();

        public Login()
        {
            InitializeComponent();
            txtUser.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarListaUsuarios();
            string nombre = txtUser.Text.ToString().Trim();
            string contraseña = txtPassword.Text.ToString().Trim();
            bool existe;
          
            Usuario usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Contraseña = contraseña;

           
                if (!CuentaConAcceso(usuario))
                {
                    MessageBox.Show("Datos no validos!!");
                }
                else
                {

                    Menu menu = new Menu();
                    menu.Show();
                    
                }

                // Reseteamos los labels 

                
                txtUser.Text = "";
                txtPassword.Text = "";
                lblError.Visible = false;
                lblErrorPassword.Visible = false;
                txtUser.Focus();

            

        }

        private void ActualizarListaUsuarios()
        {
            listado_usuarios = acceso.ObtenerUsuarios();
        }

        private bool CuentaConAcceso(Usuario usuario)
        {
                foreach (Usuario usuario1 in listado_usuarios)
                {
                    if (usuario1.Nombre.Equals(usuario.Nombre) && usuario1.Contraseña.Equals(usuario.Contraseña))
                    {
                        return true;
                    }
                }

            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            Registro form = new Registro();
            form.ShowDialog();
        }


        // Validacion campo usuario 

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el TextBox actual
            TextBox textBox = sender as TextBox;

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblError.Text = "Solo se permiten letras y números.";
                lblError.Visible = true;
            }
            else
            {
                if(char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                } else
                {
                    if( textBox.Text.Length >= 20 )
                    {
                        lblError.Text = "El nombre de usuario debe tener entre 5 y 20 caracteres.";
                        lblError.Visible = true ;
                        e.Handled  = true;
                    }
                    else
                    {
                        lblError.Visible= false ;
                        usuario_correcto = true ;
                    }
                }
            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                
               if( usuario_correcto.Equals(true) )
                {
                    lblError.Text = "Usuario correcto!!";
                    lblError.Visible = true;
                    txtPassword.Select();
                } 
            }
        }

        // Validacion campo contraseña 

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if( !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lblErrorPassword.Text = "Solo se permiten letras y números.";
                lblErrorPassword.Visible = true;
                e.Handled = true;
            } 
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (txtBox.Text.Length >= 20)
                    {
                        lblErrorPassword.Text = "La contraseña no puede exceder de 20 caracteres.";
                        lblErrorPassword.Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                        lblError.Visible = false;
                        contraseña_correcta = true;
                    }
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if( contraseña_correcta.Equals(true))
                {
                    lblErrorPassword.Text = "Contraseña correcta!!";
                    lblErrorPassword.Visible = true;
                    btnLogin.Focus();
                }
            }
        }

    }
}
