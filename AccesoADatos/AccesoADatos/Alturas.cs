using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    internal class Alturas
    {
        private string provincia;
        private string situacionAltMax;
        private int alturaMaxima;
        private string situacionAltMin;
        private int alturaMinima;

        public Alturas() 
        {

        }

        public Alturas(string provincia, string situacionAltMax, int alturaMaxima, string situacionAltMin, int alturaMinima)
        {
            this.Provincia = provincia;
            this.SituacionAltMax = situacionAltMax;
            this.AlturaMaxima = alturaMaxima;
            this.SituacionAltMin = situacionAltMin;
            this.AlturaMinima = alturaMinima;
        }

        public string Provincia { get => provincia; set => provincia = value; }
        public string SituacionAltMax { get => situacionAltMax; set => situacionAltMax = value; }
        public int AlturaMaxima { get => alturaMaxima; set => alturaMaxima = value; }
        public string SituacionAltMin { get => situacionAltMin; set => situacionAltMin = value; }
        public int AlturaMinima { get => alturaMinima; set => alturaMinima = value; }


    }
}
