using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFruta
{
    public class Usuario
    {
       private string nombre;
       private string contraseña;

        public Usuario()
        {

        }

        public Usuario(string nombre, string contraseña)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
