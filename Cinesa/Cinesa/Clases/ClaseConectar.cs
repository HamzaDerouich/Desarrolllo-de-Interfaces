using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinesa.Clases
{
    public class ClaseConectar
    {

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;

        public ClaseConectar() 
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=cine;Uid=admin;pwd=Pilukina_2024;old guids=true"; ;
        }

        public List<ClaseCartelera> SelectCartelera()
        {
            List<ClaseCartelera> listado_carteleras = new List<ClaseCartelera>();
            try
            {
                conexion .Open ();
                string consulta_sql = "SELECT * FROM cartelera_total";

                using (comando = new MySqlCommand(consulta_sql, conexion)) 
                {
                    datos = comando.ExecuteReader ();
                    while (datos.Read()) 
                    {
                        ClaseCartelera claseCartelera = new ClaseCartelera();
                        claseCartelera.Id_pelicula = (string)datos["id_Pelicula"];
                        claseCartelera.Titulo = (string)datos["titulo"];
                        claseCartelera.Cartel = (byte[])datos["cartel"];
                        claseCartelera.Minutos = (int)datos["minutos"];
                        claseCartelera.Fecha = (DateTime)datos["fecha"];
                        claseCartelera.Sala = (int)datos["sala"];

                        listado_carteleras.Add(claseCartelera);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en realizar la consulta, error: {ex} ");
            }
            return listado_carteleras ;
        }

        public ClaseCartelera SelectInfoCartel(string id, int sala)
        {
            List<ClaseCartelera> listado_carteleras = new List<ClaseCartelera>();
            try
            {
                conexion.Open();
                string consulta_sql = "SELECT * FROM cartelera_total WHERE id_Pelicula = @id AND sala = @sala";

                using (comando = new MySqlCommand(consulta_sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@sala", sala);
                    datos = comando.ExecuteReader();
                    while (datos.Read())
                    {
                        ClaseCartelera claseCartelera = new ClaseCartelera();
                        claseCartelera.Id_pelicula = (string)datos["id_Pelicula"];
                        claseCartelera.Titulo = (string)datos["titulo"];
                        claseCartelera.Cartel = (byte[])datos["cartel"];
                        claseCartelera.Minutos = (int)datos["minutos"];
                        claseCartelera.Fecha = (DateTime)datos["fecha"];
                        claseCartelera.Sala = (int)datos["sala"];

                        return claseCartelera;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en realizar la consulta, error: {ex} ");
            }
            return null;
        }


        public ClaseSala SelectSalas(int id)
        {
            List<ClaseCartelera> listado_carteleras = new List<ClaseCartelera>();
            try
            {
                conexion.Open();
                string consulta_sql = "SELECT * FROM salaCine WHERE idSala = @id";

                using (comando = new MySqlCommand(consulta_sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    datos = comando.ExecuteReader();
                    while (datos.Read())
                    {
                        ClaseSala sala = new ClaseSala();
                        sala.IdSala = (int)datos["idSala"];
                        sala.Filas = (int)datos["filas"];
                        sala.Columnas = (int)datos["columnas"];

                        return sala;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en realizar la consulta, error: {ex} ");
            }
            return null;
        }

        public List<ClaseFacturacion> SelectFacturacion(int id)
        {
            List<ClaseFacturacion> listado_facturacion = new List<ClaseFacturacion>();
            try
            {
                conexion.Open();
                string consulta_sql = "SELECT * FROM facturacionCine WHERE idSala = @id AND ocupado = 1 ";

                using (comando = new MySqlCommand(consulta_sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    datos = comando.ExecuteReader();
                    while (datos.Read())
                    {
                        
                        ClaseFacturacion facturacion = new ClaseFacturacion();
                        facturacion.Id = (int)datos["id"];
                        facturacion.IdSala = (int)datos["idSala"];
                        facturacion.Fila = (int)datos["fila"];
                        facturacion.Columna = (int)datos["columna"];
                        facturacion.Sesion = (string)datos["sesion"];
                        facturacion.Ocupado = (int)datos["ocupado"];
                      
                        return listado_facturacion;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en realizar la consulta, error: {ex} ");
            }
            return listado_facturacion;
        }

        public List<ClaseCartel> SelectCartel(string id)
        {
            List<ClaseCartel> listado_carteleras = new List<ClaseCartel>();
            try
            {
                conexion.Open();
                string consulta_sql = "SELECT id_Pelicula, sala , fecha FROM cartelera WHERE activo = 1 and id_Pelicula = @id ";

                using (comando = new MySqlCommand(consulta_sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    datos = comando.ExecuteReader();
                    while (datos.Read())
                    {
                        ClaseCartel claseCartel = new ClaseCartel();
                        claseCartel.Id_pelicula = (string)datos["id_Pelicula"];
                        claseCartel.Sala = (int)datos["sala"];
                        claseCartel.Fecha = (DateTime)datos["fecha"];
                       
                      
                        listado_carteleras.Add(claseCartel);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en realizar la consulta, error: {ex} ");
            }
            return listado_carteleras;
        }
    }
}
