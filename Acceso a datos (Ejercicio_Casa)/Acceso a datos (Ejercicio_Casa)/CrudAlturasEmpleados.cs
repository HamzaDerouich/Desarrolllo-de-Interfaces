using Acceso_Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_datos__Ejercicio_Casa_
{
    internal class CrudAlturasEmpleados
    {
        private string ruta;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public CrudAlturasEmpleados( string ruta ) 
        { 
            this.ruta = ruta;
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
        }


        public List<Altura> SelectAlturas()
        {
            List<Altura> listadoAlturas = new List<Altura>();

            conn.ConnectionString = this.ruta;
            conn.Open();
            string consultaSql = "SELECT * FROM alturas";

            using( cmd = new MySqlCommand(consultaSql, conn)) 
            { 

                reader = cmd.ExecuteReader();
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


                reader.Close();
                conn.Close();

                return listadoAlturas;
                

            }
        }

        public List<Empleado> SelectEmpleados()
        {
            List<Empleado> listadoAlturas = new List<Empleado>();

            conn.ConnectionString = this.ruta;
            conn.Open();
            string consultaSql = "SELECT * FROM empleados";

            using (cmd = new MySqlCommand(consultaSql, conn))
            {

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.Dni = (string)reader["Dni"];
                    empleado.Password  = (string)reader["Password"];
                    empleado.Nivel = (int)reader["Nivel"];
                    empleado.Image = (string)reader["Imagen"];
                    listadoAlturas.Add(empleado);
                }


                reader.Close();
                conn.Close();

                return listadoAlturas;
            }
        }

        public int InsertAlturas(Altura altura)
        {
            string acceso = this.ruta;
            string consultaSql = "INSERT INTO alturas (Provincia, SituacionAltMax, AlturaMaxima, SituacionAltMin, AlturaMinima) VALUES (@Provincia, @SituacionAltMax, @AlturaMaxima, @SituacionAltMin, @AlturaMinima)";

            int codigo = 0;

            conn.ConnectionString = acceso;
            conn.Open();

            cmd = new MySqlCommand(consultaSql, conn);


            using (MySqlCommand comando = new MySqlCommand(consultaSql, conn))
            {

                comando.Parameters.AddWithValue("@Provincia", altura.Provinicia);
                comando.Parameters.AddWithValue("@SituacionAltMax", altura.SituacionAltMax);
                comando.Parameters.AddWithValue("@AlturaMaxima", altura.AlturaMaxima);
                comando.Parameters.AddWithValue("@SituacionAltMin", altura.SituacionAltMin);
                comando.Parameters.AddWithValue("@AlturaMinima", altura.AlturaMinima);


                codigo = comando.ExecuteNonQuery();
            }

            conn.Close();

            return codigo;
        }

        public int InsertEmpleados(Empleado empleado)
        {
            string acceso = this.ruta;
            string consultaSql = "INSERT INTO empleados (dni,password,nivel,imagen,imagenAlt) VALUES (@dni, @password, @nivel, @imagen,@imagenAlt)";

            int codigo = 0;

            conn.ConnectionString = acceso;
            conn.Open();

            cmd = new MySqlCommand(consultaSql, conn);


            using (MySqlCommand comando = new MySqlCommand(consultaSql, conn))
            {

                comando.Parameters.AddWithValue("@dni", empleado.Dni );
                comando.Parameters.AddWithValue("@password", empleado.Password);
                comando.Parameters.AddWithValue("@nivel", empleado.Nivel);
                comando.Parameters.AddWithValue("@imagen", empleado.Image);
                comando.Parameters.AddWithValue("@imagenAlt", empleado.ImagenAlt);


                codigo = comando.ExecuteNonQuery();
            }

            conn.Close();

            return codigo;
        }


    }
}
