using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace TP2_Lab
{
    [Serializable]
    public class Propietario:IComparable
    {
        private string nombre;
        private string apellido;
        private long dni;
        private int cantPropiedadesP;

        public int CantPropiedadesP
        {
            get { return cantPropiedadesP; }
            set { cantPropiedadesP = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public long DNI
        {
            get { return dni; }
            set
            {
                dni = value;
                if (dni < 10000000 || dni > 99999999)
                {
                  throw new NumeroDniException("El numero de dni no es valido");
                }
                //string dniStr = dni.ToString(); // Convertir a cadena para verificar longitud
                //if (!Regex.IsMatch(dniStr, @"^\d{8}$") || dni < 10000000 || dni > 99999999)
                //{
                //    throw new NumeroDniException("El numero de dni no es valido");
                //}
            }
        }
        public Propietario(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
            cantPropiedadesP = 0;
        }

        public int CompareTo(Object obj)
        {
            return this.DNI.CompareTo(((Propietario)obj).DNI);
        }

        public override string ToString()
        {
            return apellido + " " + nombre;
        }
    }
}
