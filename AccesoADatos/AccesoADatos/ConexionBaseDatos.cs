using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoADatos
{
    internal class ConexionBaseDatos
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        static List<Alturas> listadoAlturas = new List<Alturas>();

        public ConexionBaseDatos()
        {
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
           
        }

        public List<Alturas> ObtenerDatos()
        {
            string myConnectionString = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            string consultaSql = "Select * From alturas";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                cmd = new MySqlCommand();
                cmd.CommandText = consultaSql;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader(); // datos = cm.ex .... 

                while (reader.Read())
                {
                    Alturas altura = new Alturas();
                    altura.Provincia = (string)reader["Provincia"];
                    altura.SituacionAltMax = (string)reader["SituacionAltMax"];
                    altura.AlturaMaxima = (int)reader["AlturaMaxima"];
                    altura.SituacionAltMin = (string)reader["SituacionAltMin"];
                    altura.AlturaMinima = (int)reader["AlturaMinima"];

                    listadoAlturas.Add(altura);
                }
                reader.Close();
                conn.Close();

                return listadoAlturas;
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }


        public int InsertarDatos(Alturas altura)
        {

            string myConnectionString = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
            string consulta = "insert into alturas values(?1,?2,?3,?4,?5,)";

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            cmd = new MySqlCommand(consulta,conn);
            

            conn.Open();
            int codigo = cmd.ExecuteNonQuery();


            cmd.Parameters.AddWithValue("?1", altura.Provincia);
            cmd.Parameters.AddWithValue("?2", altura.SituacionAltMax);
            cmd.Parameters.AddWithValue("?3", altura.AlturaMaxima);
            cmd.Parameters.AddWithValue("?4", altura.SituacionAltMin);
            cmd.Parameters.AddWithValue("?5", altura.AlturaMinima);

            conn.Close() ;  

            return codigo;
        }

        public bool DeletearDatos(Alturas altura) 
        {
            return false;
        }

    }
}
