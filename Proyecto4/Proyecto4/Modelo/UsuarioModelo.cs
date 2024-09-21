using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Modelo
{
    internal class UsuarioModelo
    {

        List<Usuario> listaUsuarios = new List<Usuario>();
        public void GuardarUsuarioModel(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }
        public List<Usuario> ConsultarUsuarios()
        {
            return listaUsuarios;
        }

    }
}

