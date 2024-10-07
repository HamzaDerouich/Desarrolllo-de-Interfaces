using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    internal class Usuario
    {
        private int id;
        private string name;
        private string text;

       public Usuario()
        {

        }

        public Usuario(int id, string name, string text)
        {
            this.Id = id;
            this.Name = name;
            this.Text = text;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Text { get => text; set => text = value; }
    }
}
