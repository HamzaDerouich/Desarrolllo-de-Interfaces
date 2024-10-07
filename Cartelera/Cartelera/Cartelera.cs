using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartelera
{
    internal class Cartelera
    {

        private int indice;
        private string titulo;
        private string sesion;
        private int sala;
        private byte[] cartel;

        public Cartelera()
        {

        }

        public Cartelera(int indice, string titulo, string sesion, int sala, byte[] cartel)
        {
            this.Indice = indice;
            this.Titulo = titulo;
            this.Sesion = sesion;
            this.Sala = sala;
            this.Cartel = cartel;
        }

        public int Indice { get => indice; set => indice = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Sesion { get => sesion; set => sesion = value; }
        public int Sala { get => sala; set => sala = value; }
        public byte[] Cartel { get => cartel; set => cartel = value; }
    }
}
