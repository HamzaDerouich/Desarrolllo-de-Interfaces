using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBrainTraining
{
    internal class Ranking
    {
        private string nombre;
        private int puntos;
        private string fecha;

        public Ranking()
        {

        }

        public Ranking(string nombre, int puntos, string fecha)
        {
            this.Nombre = nombre;
            this.Puntos = puntos;
            this.Fecha = fecha;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
