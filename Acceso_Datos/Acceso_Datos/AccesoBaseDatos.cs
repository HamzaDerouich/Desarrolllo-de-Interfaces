using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    internal class AccesoBaseDatos
    {
        
        private string path;
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader lector;



        public AccesoBaseDatos() 
        {
            
        }

        public AccesoBaseDatos(string path) 
        {
            this.path = path;
            conexion = new MySqlConnection();
            comando = new MySqlCommand(); 
        }


        

        public List<Altura> Select()
        {
            
            List<Altura> listadoAlturas = new List<Altura>();

            string acceso = path;
            string consultaSql = "Select * From alturas";

            try
            {
                conexion.ConnectionString = acceso; // Nos conectamos al servidor de base de datos 
                conexion.Open(); // Abrimos la conexion 


                // Ejecutamos la consulta sql 
                // Establecemos la conexion

                using (comando = new MySqlCommand(consultaSql,conexion))
                {
                    lector = comando.ExecuteReader(); // Ejecutamos la consulta 

                    while (lector.Read())
                    {
                        Altura altura = new Altura();
                        altura.Provinicia = (string)lector["Provincia"];
                        altura.SituacionAltMax = (string)lector["SituacionAltMax"];
                        altura.AlturaMaxima = (int)lector["AlturaMaxima"];
                        altura.SituacionAltMin = (string)lector["SituacionAltMin"];
                        altura.AlturaMinima = (int)lector["AlturaMinima"];

                        listadoAlturas.Add(altura);

                    }

                    lector.Close();
                    conexion.Close();
              
                }

                return listadoAlturas;
            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        public int Insert(Altura altura)
        {
            string acceso = path;
            string consultaSql = "INSERT INTO alturas (Provincia, SituacionAltMax, AlturaMaxima, SituacionAltMin, AlturaMinima) VALUES (@Provincia, @SituacionAltMax, @AlturaMaxima, @SituacionAltMin, @AlturaMinima)";

            int codigo = 0;
            
            conexion.ConnectionString = acceso;
            conexion.Open();

            comando = new MySqlCommand(consultaSql, conexion);


            using (MySqlCommand comando = new MySqlCommand(consultaSql, conexion))
            {
                
                comando.Parameters.AddWithValue("@Provincia", altura.Provinicia);
                comando.Parameters.AddWithValue("@SituacionAltMax", altura.SituacionAltMax);
                comando.Parameters.AddWithValue("@AlturaMaxima", altura.AlturaMaxima);
                comando.Parameters.AddWithValue("@SituacionAltMin", altura.SituacionAltMin);
                comando.Parameters.AddWithValue("@AlturaMinima", altura.AlturaMinima);

                
                codigo = comando.ExecuteNonQuery();
            }

            conexion.Close();

            return codigo;
        }

        public int Delete(Altura altura) 
        {

            string acceso = path;
            string consultaSql = "DELETE FROM alturas WHERE Provincia = @Provincia";
            int codigo = 0;

            conexion.ConnectionString = acceso; 
            conexion.Open();

            using ( comando = new MySqlCommand( consultaSql, conexion))
            {
                comando.Parameters.AddWithValue("@Provincia", altura.Provinicia);


                codigo = comando.ExecuteNonQuery();
            }


            return codigo;
        }

    }
}
