using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    public class Casa : Propiedad
    {
        private int diasPermitidos; //dias minimo
        //private int diasTotales;     //dias totales
        Propietario miPropietario;

        public Casa(int diasPermitidos, Propietario miPropietario, double precio, string direccion, string localidad, int cantCamas, bool[] servicios)
            : base(precio, direccion, localidad, cantCamas, servicios)
        {
            this.diasPermitidos = diasPermitidos;
            this.miPropietario = miPropietario;
        }
        public string Propietario
        {
            get{ return miPropietario.ToString(); }
        }
        public override double CalcularPrecio()
        {
            double precioServicios = 0;
            double precio;
            double precioxCamas;

            precioxCamas = cantCamas * 100;

            for (int i = 0; i < 6; i++)
            {
                if (servicios[i] == true)
                {
                    precioServicios += 102;
                }
            }
            precio = precioServicios + precioxCamas + precioBasico;
            return precio;
        }

        public int DiasPermitidos
        {
            get { return diasPermitidos; }
        }

        public double DiasAReservar(int dias)
        {
            double ret = diasPermitidos * precioBasico;
            if (dias > diasPermitidos)
                ret += (dias - diasPermitidos) * precioBasico * 0.9;

            return ret;
        }
    }
}
