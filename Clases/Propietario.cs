﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP2_Lab
{
    [Serializable]
    public class Propietario
    {
        private string nombre;
        private string apellido;
        private long dni;

        public long DNI
        {
            get { return dni; }
            set
            {
                dni = value;
                if(dni<10000000 || dni > 99999999)
                {
                    throw new NumeroDniException("DNI no valido");
                }
            }
        }

        public Propietario(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dni;
        }

        public override string ToString()
        {
            return apellido + ", " + nombre;
        }
    }
}
