using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP2_Lab
{
    [Serializable]
    public class Cliente: IExportable
    {
        private string nombre;
        private long dni;

       
        //Propiedades
        public long DNI
        {
            get { return dni; }
        } 

        //Constructor
        public Cliente(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
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
