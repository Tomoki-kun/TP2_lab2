using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TP2_Lab
{
    [Serializable]
    public class Casa : Propiedad
    {
        private int diasPermitidos; //dias minimo
        //private int diasTotales;     //dias totales
        private Propietario miPropietario;
        #region Propiedades
        public string Propietario
        {
            get{ return miPropietario.ToString(); }
        }

        public long DNIpropietario
        {
            get { return miPropietario.DNI; }
        }
        public int DiasPermitidos
        {
            get { return diasPermitidos; }
            set { diasPermitidos = value;}
        }
        #endregion

        //Constructor
        public Casa(int nro,int diasPermitidos, Propietario miPropietario, double precio, string direccion, string localidad, int cantCamas, bool[] servicios, Image pic,Image pic2)
            : base(nro,precio, direccion, localidad, cantCamas, servicios, pic,pic2)
        {
            this.diasPermitidos = diasPermitidos;
            this.miPropietario = miPropietario;
        }

        #region Metodos
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

        public double DiasAReservar(int dias)
        {
            double ret = diasPermitidos * precioBasico;
            if (dias > diasPermitidos)
                ret += (dias - diasPermitidos) * precioBasico * 0.9;

            return ret;
        }
        #endregion
    }
}
