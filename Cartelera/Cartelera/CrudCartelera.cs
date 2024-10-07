using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartelera
{
    internal class CrudCartelera
    {
        private string ruta;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public CrudCartelera()
        {
            this.ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            con = new MySqlConnection(ruta);
            cmd = new MySqlCommand();
        }

        public List<Cartelera> SelectCartelera()
        {
            try
            {

                List<Cartelera> carteleras = new List<Cartelera>();
                con.ConnectionString = this.ruta;
                con.Open();

                string consulta = "SELECT * FROM cartelera";

                using (cmd = new MySqlCommand( consulta, con )) 
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read()) 
                    {
                        Cartelera carteles = new Cartelera();
                        carteles.Indice = (int)reader["indice"];
                        carteles.Titulo = (string)reader["titulo"];
                        carteles.Sesion = (string)reader["sesion"];
                        carteles.Sala = (int)reader["sala"];
                        carteles.Cartel = (byte[])reader["cartel"];

                        carteleras.Add(carteles);
                    }
                    
                }

                reader.Close();
                con.Close();


                return carteleras;

            }
            catch (IOException ex) 
            {
                Console.WriteLine( ex.ToString() );
            }

            return null;
        }
    }
}
