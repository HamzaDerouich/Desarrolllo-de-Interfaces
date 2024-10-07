using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBrainTraining
{

    
    internal class Crud
    {
        private string ruta;
        private MySqlConnection conexion;
        private MySqlCommand command;
        private MySqlDataReader lector;

        public Crud( string ruta)
        {
            this.ruta = ruta;
            conexion = new MySqlConnection();
            command = new MySqlCommand();
        }


        public List<Ranking> SelectRanking()
        {
            List<Ranking> rankings = new List<Ranking>();
            try
            {
                conexion.ConnectionString = ruta;
                conexion.Open();
                string consultaSql = "SELECT * FROM ranking ORDER BY puntos DESC";

                using (command = new MySqlCommand(consultaSql, conexion))
                {
                   
                    lector = command.ExecuteReader();

                    while (lector.Read()) 
                    {

                        Ranking ranking = new Ranking();
                        ranking.Nombre = (string)lector["nombre"];
                        ranking.Puntos = (int)lector["puntos"];
                        ranking.Fecha = (string)lector["fecha"];

                        rankings.Add(ranking);  
                    }

                    lector.Close();
                    conexion.Close();


                    return rankings;
                }


            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());   
            }

            return rankings;
        }

        public void InsertarRanking( Ranking ranking )
        {
            conexion.ConnectionString = ruta;
            conexion.Open(); 
            string consultaSql = "INSERT INTO ranking (nombre, puntos, fecha) VALUES (@nombre, @puntos, @fecha)";


            using (command = new MySqlCommand(consultaSql, conexion))
            {
                command.Parameters.AddWithValue("@nombre", ranking.Nombre);
                command.Parameters.AddWithValue("@puntos", ranking.Puntos);
                command.Parameters.AddWithValue("@fecha", ranking.Fecha);
                command.ExecuteNonQuery();

            }
        }

    }
}
