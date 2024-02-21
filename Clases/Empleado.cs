using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    internal class Empleado: Usuario
    {
        public Empleado(string user, string pas) : base(user, pas)
        {
        }


        public void CambiarPassword(string nuevaP)
        {
        }
    }
}
