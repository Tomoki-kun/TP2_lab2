using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    internal class Administrador: Usuario
    {
        public Administrador(string user, string password) : base(user, password)
        {
        }

        public void CrearUsuario(string nom, string cont, bool tipo)
        {
        }
    }
}
