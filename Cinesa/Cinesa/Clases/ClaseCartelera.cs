using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinesa.Clases
{
    public class ClaseCartelera
    {
        private string id_pelicula;
        private string titulo;
        private byte[] cartel;
        private int minutos;
        private DateTime fecha;
        private int sala;

        public ClaseCartelera() 
        {

        }

        public ClaseCartelera(string id_pelicula, string titulo, byte[] cartel, int minutos, DateTime fecha, int sala)
        {
            this.Id_pelicula = id_pelicula;
            this.Titulo = titulo;
            this.Cartel = cartel;
            this.Minutos = minutos;
            this.Fecha = fecha;
            this.Sala = sala;
        }

        public string Id_pelicula { get => id_pelicula; set => id_pelicula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public byte[] Cartel { get => cartel; set => cartel = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Sala { get => sala; set => sala = value; }
    }
}
