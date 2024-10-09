using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace EjercicioFruta
{
    internal class CRUD
    {

       private string ruta;
       private MySqlConnection connection;
       private MySqlCommand command;
       private MySqlDataReader reader;

        public CRUD(String ruta)
        {
            this.ruta = ruta;
            this.connection = new MySqlConnection();
            this.command = new MySqlCommand();
        }

        public List<Frutas> ObtenerFrutas() 
        {
            try
            {

                List<Frutas> listado_frrutas = new List<Frutas>();
                connection.ConnectionString = this.ruta;
                connection.Open();

                string consulta = "SELECT * FROM frutas";

                using (command = new MySqlCommand(consulta, connection))
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                      Frutas frutas = new Frutas();
                      frutas.Id = (int)reader["id"];
                      frutas.Nombre = (string)reader["nombre"];
                      frutas.Precio = (float)reader["precio"];
                      frutas.Imagen = (byte[])reader["imagen"];

                        listado_frrutas.Add(frutas);
                       
                    }
                }

                reader.Close();
                connection.Close();


                return listado_frrutas;

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }


    }


}
