using Acceso_Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos_2
{

  
   
    internal class Crud
    {
        private string ruta;
        MySqlConnection connection;
        MySqlCommand comando;
        MySqlDataReader reader;

        public Crud(string ruta)
        {
            this.ruta = ruta;
            connection = new MySqlConnection();
            comando = connection.CreateCommand();
        }

        public List<Altura> SelectAltura() 
        {
            try
            {
                List<Altura> listadoAlturas = new List<Altura> ();

                connection.ConnectionString = this.ruta;
                connection.Open();
                string sql = "SELECT * FROM alturas";
                using ( comando = comando = new MySqlCommand(sql, connection))
                {
                    reader = comando.ExecuteReader();
                    while (reader.Read()) 
                    {
                        Altura altura = new Altura(); 
                        altura.Provinicia = (string)reader["Provincia"];
                        altura.SituacionAltMax = (string)reader["SituacionAltMax"];
                        altura.AlturaMaxima = (int)reader["AlturaMaxima"];
                        altura.SituacionAltMin = (string)reader["SituacionAltMin"];
                        altura.AlturaMinima = (int)reader["AlturaMinima"];

                        listadoAlturas.Add(altura); 

                    }
                }
                 
                reader.Close();
                connection.Close(); 

                return listadoAlturas;

            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
            }
           
            return null;
        }

        public int InsertAltura(Altura altura)
        {
            try
            {
                int codigo = 0;
                connection.ConnectionString = this.ruta;
                connection.Open();
                string sql = "INSERT INTO alturas(Provincia, SituacionAltMax, AlturaMaxima, SituacionAltMin, AlturaMinima) values (@Provincia, @SituacionAltMax, @AlturaMaxima, @SituacionAltMin, @AlturaMinima)";

                using( comando = new MySqlCommand(sql, connection))
                {
                    // Insertamos los valores ingresados por el usario 

                    comando.Parameters.AddWithValue("@Provincia",altura.Provinicia);
                    comando.Parameters.AddWithValue("@SituacionAltMax", altura.SituacionAltMax);
                    comando.Parameters.AddWithValue("@AlturaMaxima", altura.AlturaMaxima);
                    comando.Parameters.AddWithValue("@SituacionAltMin", altura.Provinicia);
                    comando.Parameters.AddWithValue("@AlturaMinima", altura.Provinicia);

                     codigo = comando.ExecuteNonQuery();
                }

                return codigo;

            }
            catch (IOException ex) { Console.WriteLine(ex); }

            return 0;
        }

        public int DeleteAltura(Altura altura) 
        {
            try
            {
                int codigo = 0;
                string path = this.ruta;
                string sql = "DELETE FROM alturas WHERE Provincia = @Provincia ";
                connection.ConnectionString = path;
                connection.Open();

                using (comando = new MySqlCommand(sql, connection)) 
                {

                    // Ejecutamos la sentencia 

                    comando.Parameters.AddWithValue("@Provincia",altura.Provinicia);

                    codigo = comando.ExecuteNonQuery();

                    return codigo;
                }

                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return 0;
        }
    }
}
