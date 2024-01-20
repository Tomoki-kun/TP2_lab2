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

        //Constructor
        public Cliente(string nombre, long dni)
        {
            this.nombre = nombre;
            this.DNI = dni;
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
