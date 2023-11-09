using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP2_Lab
{
    [Serializable]
    public class Cliente
    {
        private string nombre;
        private long dni;

        public Cliente(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public override string ToString()
        {
            return "Cliente: " + nombre;
        }
    }
}
