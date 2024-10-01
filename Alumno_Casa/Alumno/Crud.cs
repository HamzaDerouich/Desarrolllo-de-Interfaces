using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno
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
            comando = new MySqlCommand();
        }

        public List<Alumno> SelectAltura()
        {
            try
            {
                List<Alumno> listadoAlturas = new List<Alumno>();

                connection.ConnectionString = this.ruta;
                connection.Open();
                string sql = "SELECT * FROM alumnos";
                using (comando = new MySqlCommand(sql, connection))
                {
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Alumno alumno = new Alumno();
                        alumno.Expediente = (string)reader["expediente"];
                        alumno.Nombre = (string)reader["nombre"];
                        alumno.Apellidos = (string)reader["apellidos"];
                        alumno.Sge = (int)reader["SGE"];
                        alumno.Di = (int)reader["DI"];
                        alumno.Ad = (int)reader["AD"];
                        alumno.Psp = (int)reader["PSP"];
                        alumno.Pmm = (int)reader["PMM"];

                        listadoAlturas.Add(alumno);

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

        public int InsertarAlumno( Alumno alumno)
        {
            int codigo = 0;
            try
            {
               
                string consultaSQL = "INSERT INTO alumnos(Expediente, Nombre, Apellidos, SGE , DI, AD, PSP ,PMM) VALUES(@Expediente, @Nombre, @Apellidos, @SGE, @DI, @AD, @PSP,@PMM)";
                connection.ConnectionString = this.ruta;
                connection.Open();

                using (comando = new MySqlCommand(consultaSQL,connection)) 
                {

                    comando.Parameters.AddWithValue("@Expediente",alumno.Expediente);
                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
                    comando.Parameters.AddWithValue("@SGE", alumno.Sge);
                    comando.Parameters.AddWithValue("@DI", alumno.Di);
                    comando.Parameters.AddWithValue("@AD", alumno.Ad);
                    comando.Parameters.AddWithValue("@PSP", alumno.Psp);
                    comando.Parameters.AddWithValue("@PMM", alumno.Pmm);


                    codigo = comando.ExecuteNonQuery();
                }

                connection.Close();
                return codigo;
            }
            catch (IOException ex) 
            {
                 Console.WriteLine (ex.Message);
            }
           



            return codigo;
        }

        public int DeleteAlumno(string Expediente)
        {
            int codigo = 0;
            try
            {

                string consultaSQL = "DELETE FROM alumnos WHERE Expediente = @Expediente";
                connection.ConnectionString = this.ruta;
                connection.Open();

                using (comando = new MySqlCommand(consultaSQL, connection))
                {
                    comando.Parameters.AddWithValue("@Expediente", Expediente);
                    codigo = comando.ExecuteNonQuery();
                }

                connection.Close();
                return codigo;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return codigo;
        }

        public int UpdateAlumno(Alumno alumno)
        {
            int codigo = 0;
            try
            {

                string consultaSQL =
                "UPDATE alumnos " +  
                 "SET Expediente = @Expediente, " +
                 "Nombre = @Nombre, " +
                 "Apellidos = @Apellidos, " +
                 "SGE = @SGE, " +
                 "DI = @DI, " +
                 "AD = @AD, " +
                 "PSP = @PSP, " +
                 "PMM = @PMM " +
                 "WHERE Expediente = @Expediente;";
                connection.ConnectionString = this.ruta;
                connection.Open();

                using (comando = new MySqlCommand(consultaSQL, connection))
                {

                    comando.Parameters.AddWithValue("@Expediente", alumno.Expediente);
                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
                    comando.Parameters.AddWithValue("@SGE", alumno.Sge);
                    comando.Parameters.AddWithValue("@DI", alumno.Di);
                    comando.Parameters.AddWithValue("@AD", alumno.Ad);
                    comando.Parameters.AddWithValue("@PSP", alumno.Psp);
                    comando.Parameters.AddWithValue("@PMM", alumno.Pmm);


                    codigo = comando.ExecuteNonQuery();
                }

                connection.Close();
                return codigo;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }




            return codigo;
        }
    }
}
