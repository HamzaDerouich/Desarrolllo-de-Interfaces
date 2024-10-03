using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_datos__Ejercicio_Casa_
{
    internal class Empleado
    {
        private string dni;
        private string password;
        private int nivel;
        private string image;
        private string imagenAlt;

        public Empleado()
        {

        }

        public Empleado(string dni, string password, int nivel, string image, string imagenAlt)
        {
            this.Dni = dni;
            this.Password = password;
            this.Nivel = nivel;
            this.Image = image;
            this.ImagenAlt = imagenAlt;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Password { get => password; set => password = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string Image { get => image; set => image = value; }
        public string ImagenAlt { get => imagenAlt; set => imagenAlt = value; }
    }
}
