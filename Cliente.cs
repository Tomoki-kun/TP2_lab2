using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP2_Lab
{
    [Serializable]
    public class Cliente:IExportable
    {
        private string nombre;
        private long dni;  
        public long DNI
        {
            get { return dni; }
            set
            {
                dni = value;
                if (dni <10000000 || dni > 99999999)
                {
                    throw new NumeroDniException("El numero de dni no es valido");
                }
            }
        }



        public Cliente(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }


        public override string ToString()
        {
            return nombre;
        }

        public string Exportar()
        {
            return $"{nombre},{dni}";
        }
    }
}
