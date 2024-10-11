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
    public partial class Registro : Form
    {
        bool usuario_correcto = false;
        bool contraseña_correcta = false;
        static CRUD acceso = new CRUD("Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true");
        List<Usuario> listado_usuarios = acceso.ObtenerUsuarios();

        public Registro()
        {
            InitializeComponent();
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void btnSing_Click(object sender, EventArgs e)
        {

            string nombre = txtUser.Text.ToString().Trim();
            string contraseña = txtPassword.Text.ToString().Trim();
            bool existe;

            Usuario usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Contraseña = contraseña;


            if (!ExisteUsuario(usuario))
            {
                acceso.InsertarUsuario(usuario);
                MessageBox.Show("Usuario con nombre: " + usuario.Nombre + "Registrado!!");
            }
          
            // Reseteamos los labels 
            txtUser.Text = "";
            txtPassword.Text = "";
            txtPassword.Visible = false;
            txtUser.Visible = false;


        }


        private bool ExisteUsuario(Usuario usuario)
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


        // Validar Usuario

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if( !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                lblError.Text = "Solo se permiten letras y números.";
                lblError.Visible = true;
            } else
            {
                if(char.IsControl(e.KeyChar))
                {
                    e.Handled= false;
                } else
                {
                    if( textBox.Text.Length >= 20 )
                    {
                        lblError.Text = "El nombre de usuario debe tener entre 5 y 20 caracteres.";
                        lblError.Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                        lblError.Visible= false;
                        usuario_correcto = true;
                    }
                }
            }

        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                if( usuario_correcto == true )
                {
                    lblError.Text = "Usuario correcto!!";
                    lblError.Visible = true;
                    txtPassword.Focus();
                }
            }
        }

        // Validar Contraseña 

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
             TextBox txtBox = (TextBox)sender;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lblErrorRegistroPassword.Text = "Solo se permiten letras y números.";
                lblErrorRegistroPassword.Visible = true;
                e.Handled = true;
            }
            else
            {
                if( char.IsControl(e.KeyChar))
                {
                    e.Handled= false;
                } else
                {
                    if (txtBox.Text.Length >= 20)
                    {
                        lblErrorRegistroPassword.Text = "La contraseña no puede exceder de 20 caracteres.";
                        lblErrorRegistroPassword.Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                        lblErrorRegistroPassword.Visible = false;
                        contraseña_correcta = true;
                    }
                }

            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (contraseña_correcta.Equals(true))
                {
                    lblErrorRegistroPassword.Text = "Contraseña correcta!!";
                    lblErrorRegistroPassword.Visible = true;
                    btnSing.Focus();
                }
               
            }
        }

    }
}
