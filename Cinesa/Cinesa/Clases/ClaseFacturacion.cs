using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinesa.Clases
{
    public class ClaseFacturacion
    {
        private int id;
        private int idSala;
        private int fila;
        private int columna;
        private string sesion;
        private int ocupado;
        public ClaseFacturacion() 
        {

        }

        public ClaseFacturacion(int id, int idSala, int fila, int columna, string sesion, int ocupado)
        {
            this.Id = id;
            this.IdSala = idSala;
            this.Fila = fila;
            this.Columna = columna;
            this.Sesion = sesion;
            this.Ocupado = ocupado;
        }

        public int Id { get => id; set => id = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Sesion { get => sesion; set => sesion = value; }
        public int Ocupado { get => ocupado; set => ocupado = value; }
    }
}
