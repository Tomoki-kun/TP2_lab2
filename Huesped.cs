using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    internal class Huesped
    {
        private string nombre;
        private long dni;
        private int edad;
        private DateTime fechaNacimiento;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public long DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
    }
}
