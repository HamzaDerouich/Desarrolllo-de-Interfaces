using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Alumno
    {

        private string expediente;
        private string nombre;
        private string apellidos;
        private int sge;
        private int di;
        private int ad;
        private int psp;
        private int pmm;

        public Alumno()
        {

        }

        public Alumno(string expediente, string nombre, string apellidos, int sge, int di, int ad, int psp, int pmm)
        {
            this.Expediente = expediente;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sge = sge;
            this.Di = di;
            this.Ad = ad;
            this.Psp = psp;
            this.Pmm = pmm;
        }

        public string Expediente { get => expediente; set => expediente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Sge { get => sge; set => sge = value; }
        public int Di { get => di; set => di = value; }
        public int Ad { get => ad; set => ad = value; }
        public int Psp { get => psp; set => psp = value; }
        public int Pmm { get => pmm; set => pmm = value; }
    }
}
