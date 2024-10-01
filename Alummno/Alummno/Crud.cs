using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alummno
{
    internal class Crud
    {
        string ruta;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Crud(string ruta )
        {
            this.ruta = ruta;
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
        }

        public List<ClaseDam> SelectAlumno()
        {
            List<ClaseDam> listadoAlumnos = new List<ClaseDam>();

            try
            {
                conn.ConnectionString = ruta;
                conn.Open();
                string consultaSql = "SELECT * FROM alumnos";

                using (cmd = new MySqlCommand(consultaSql, conn))
                {

                    reader = cmd.ExecuteReader();

                    while ( reader.Read())
                    {
                        ClaseDam clase = new ClaseDam();
                        clase.Expediente = (string)reader["Expediente"];
                        clase.Nombre = (string)reader["Nombre"];
                        clase.Apellido = (string)reader["Apellidos"];
                        clase.Age = (int)reader["SGE"];
                        clase.Di = (int)reader["DI"];
                        clase.Psp = (int)reader["PSP"];
                        clase.Pmm = (int)reader["PMM"];

                        listadoAlumnos.Add(clase);

                    }

                    reader.Close();
                    conn.Close();

                    return listadoAlumnos;

                     
                }


            } catch ( IOException ex ) 
            {
                Console.WriteLine( ex.ToString() ); 
            }
           
            

            return null;
        }

        public int InsertAlumno(ClaseDam alumno)
        {
            int codigo = 0;


            try
            {
                conn.ConnectionString = ruta;
                conn.Open();
                string consultaSql = "INSERT INTO alumnos(Expediente, Nombre, Apellidos, SGE, DI, PSP, PMM) values (@Expediente, @Nombre, @Apellidos, @SGE, @DI, @PSP, @PMM) ";


                using (cmd = new MySqlCommand(consultaSql, conn))
                {


                    cmd.Parameters.AddWithValue("@Expediente", alumno.Expediente);
                    cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@SGE", alumno.Age);
                    cmd.Parameters.AddWithValue("@DI", alumno.Di);
                    cmd.Parameters.AddWithValue("@PSP", alumno.Psp);
                    cmd.Parameters.AddWithValue("@PMM", alumno.Pmm);
                 

                    

                }

                codigo = cmd.ExecuteNonQuery();
                conn.Close();
                

                return codigo;

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }



            return 0;
        }

        public int DeleteAlumno(ClaseDam alumno)
        {
            int codigo = 0;


            try
            {
                conn.ConnectionString = ruta;
                conn.Open();
                string consultaSql = " DELETE FROM alumnos WHERE Expediente = @Expediente";


                using (cmd = new MySqlCommand(consultaSql, conn))
                {

                    cmd.Parameters.AddWithValue("@Expediente", alumno.Expediente);
                    

                }

                codigo = cmd.ExecuteNonQuery();

                conn.Close();

                return codigo;

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return 0;
        }

        public int Upadate(ClaseDam alumno)
        {
            int codigo = 0;
            try
            {
                conn.ConnectionString = ruta;
                conn.Open();
                string consultaSql = " Update alumnos SET  Expediente =  @Expediente , Nombre = @Nombre, Apellidos =  @Apellidos, SGE =  @SGE, DI =  @DI, PSP = @PSP, PMM = @PMM) " +
                    "WHERE Expediente = @Expediente ";


                using (cmd = new MySqlCommand(consultaSql, conn))
                {


                    cmd.Parameters.AddWithValue("@Expediente", alumno.Expediente);
                    cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@SGE", alumno.Age);
                    cmd.Parameters.AddWithValue("@DI", alumno.Di);
                    cmd.Parameters.AddWithValue("@PSP", alumno.Psp);
                    cmd.Parameters.AddWithValue("@PMM", alumno.Pmm);

                }

                codigo = cmd.ExecuteNonQuery();
                conn.Close();


                return codigo;

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }



            return 0;
        }
    }
}
