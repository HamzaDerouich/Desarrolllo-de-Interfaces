using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    internal class Crud
    {
        private string ruta;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public Crud(string ruta)
        {
            this.ruta = ruta;
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
        }

        public List<Usuario> ConsultarChat()
        {

            List<Usuario> listadoUsuarios = new List<Usuario>();

            string consultaSql = "SELECT * FROM chat";
            conn.ConnectionString = this.ruta;
            conn.Open();

            using (cmd = new MySqlCommand(consultaSql,conn)) 
            {
                reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                  

                    Usuario usuario = new Usuario();
                    usuario.Id = (int)reader["indice"];
                    usuario.Name = (string)reader["usuario"];
                    usuario.Text = (string)reader["texto"];

                    listadoUsuarios.Add(usuario);

                }

                conn.Close();
                reader.Close();

                return listadoUsuarios;

            }

            return listadoUsuarios;
        }

        public void InsertarMensaje(Usuario usuario) 
        {

            string consultaSql = "INSERT INTO chat(indice,usuario,texto) VALUES (@nombre, @usuario, @texto) ";
            conn.ConnectionString = this.ruta;
            conn.Open();

            using (cmd = new MySqlCommand(consultaSql, conn))
            {
               
                
                cmd.Parameters.AddWithValue("@nombre",usuario.Id);
                cmd.Parameters.AddWithValue("@usuario", usuario.Name);
                cmd.Parameters.AddWithValue("@texto", usuario.Text);

                cmd.ExecuteNonQuery();
            }
            
            conn.Close ();

        }
    }
}
