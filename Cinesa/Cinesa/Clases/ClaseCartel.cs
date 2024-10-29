using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinesa.Clases
{
    public class ClaseCartel
    {
        private string id_pelicula;
        private int sala;
        private DateTime fecha;
       
        public ClaseCartel() 
        {

        }

        public ClaseCartel(string id_pelicula, int sala, DateTime fecha)
        {
            this.Id_pelicula = id_pelicula;
            this.Sala = sala;
            this.Fecha = fecha;
        }

        public string Id_pelicula { get => id_pelicula; set => id_pelicula = value; }
        public int Sala { get => sala; set => sala = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
