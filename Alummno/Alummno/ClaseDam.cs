using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alummno
{
    internal class ClaseDam
    {

        string expediente;
        string nombre;
        string apellido;
        int age;
        int di;
        int psp;
        int pmm;

        public ClaseDam()
        {

        }

        public ClaseDam(string expediente, string nombre, string apellido, int age, int di, int psp, int pmm)
        {
            this.Expediente = expediente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Age = age;
            this.Di = di;
            this.Psp = psp;
            this.Pmm = pmm;
        }

        public string Expediente { get => expediente; set => expediente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Age { get => age; set => age = value; }
        public int Di { get => di; set => di = value; }
        public int Psp { get => psp; set => psp = value; }
        public int Pmm { get => pmm; set => pmm = value; }
    }
}
