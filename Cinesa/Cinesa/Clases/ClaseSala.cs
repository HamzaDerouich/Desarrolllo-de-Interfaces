using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinesa.Clases
{
    public class ClaseSala
    {
        private int idSala;
        private int filas;
        private int columnas;
        public ClaseSala() 
        {

        }

        public ClaseSala(int idSala, int filas, int columnas)
        {
            this.IdSala = idSala;
            this.Filas = filas;
            this.Columnas = columnas;
        }

        public int IdSala { get => idSala; set => idSala = value; }
        public int Filas { get => filas; set => filas = value; }
        public int Columnas { get => columnas; set => columnas = value; }
    }
}
