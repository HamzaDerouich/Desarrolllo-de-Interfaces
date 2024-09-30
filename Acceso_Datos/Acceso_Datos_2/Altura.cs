using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    internal class Altura
    {
        private string provinicia;
        private string situacionAltMax;
        private int alturaMaxima;
        private string situacionAltMin;
        private int alturaMinima;

        public Altura()
        {

        }

        public Altura(string provinicia, string situacionAltMax, int alturaMaxima, string situacionAltMin, int alturaMinima)
        {
            this.Provinicia = provinicia;
            this.SituacionAltMax = situacionAltMax;
            this.AlturaMaxima = alturaMaxima;
            this.SituacionAltMin = situacionAltMin;
            this.AlturaMinima = alturaMinima;
        }

        public string Provinicia { get => provinicia; set => provinicia = value; }
        public string SituacionAltMax { get => situacionAltMax; set => situacionAltMax = value; }
        public int AlturaMaxima { get => alturaMaxima; set => alturaMaxima = value; }
        public string SituacionAltMin { get => situacionAltMin; set => situacionAltMin = value; }
        public int AlturaMinima { get => alturaMinima; set => alturaMinima = value; }
    }
}
