using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;

namespace TP2_Lab
{
    [Serializable]
    public class Cliente: IExportable
    {
        private string nombre;
        private long dni;
        private DateTime fechaNac = new DateTime();
        private ArrayList lstHuespedes = new ArrayList();
       
        //Propiedades
        public long DNI
        {
            get { return dni; }
            set
            {
                dni = value;
                if(dni<10000000 || dni > 99999999)
                {
                    throw new NumeroDniException("DNI invalido");
                }
            }
        } 

        public DateTime FechaNacimiento
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        //Constructor
        public Cliente(string nombre, long dni, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.DNI = dni;
            this.fechaNac = fechaNac;
        }

        //Metodos
        public override string ToString()
        {
            return nombre;
        }

        //Metodo de IExportable
        public string Exportar()
        {
            return $"{nombre},{dni}";
        }
    }
}
