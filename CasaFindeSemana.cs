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
    internal class CasaFindeSemana:Casa
    {
        public CasaFindeSemana(int nro, int diasPermitidos, Propietario miPropietario,double precio, string direccion,string localidad,int cantCamas, bool[]servicios, Image pic,Image pic2)
            :base(nro,diasPermitidos,miPropietario,precio,direccion, localidad, cantCamas,servicios, pic,pic2)
        {
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
    }
}
