using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Lab
{
    [Serializable]
    public class Habitaciones:Propiedad
    {
        private int estrellas;
        private string tipoHabitacion;
        private int nroHabitacion;

        public Habitaciones(int estrellas,double precio,string direccion,string localidad, int nroHabitacion, bool[] servicios, int cantCamas,
            string tipoHabitacion) : base(precio,direccion, localidad, cantCamas,servicios)
        {
            this.estrellas = estrellas;
            this.nroHabitacion = nroHabitacion;
            this.tipoHabitacion = tipoHabitacion;
        }

        public int Estrellas
        {
            get { return estrellas; }
        }

        public string TipoHabitacion
        {
            get { return tipoHabitacion; }
        }

        public int NroHabitacion
        {
            get { return nroHabitacion; }
        }
        public override double CalcularPrecio()
        {
            double precioServicios = 0;
            double precio;
            double precioxCamas;

            precioxCamas = cantCamas * 100;

            for(int i = 0; i < 6; i++)
            {
                if(servicios[i] == true)
                {
                    precioServicios += 102;
                }
            }

            if (estrellas == 2)
            {
                if(tipoHabitacion == "Simple")
                {
                    precio = precioBasico;
                }
                else if(tipoHabitacion == "Doble")
                {
                    precio = precioBasico + (precioBasico * 0.8);
                }
                else if(tipoHabitacion == "Triple")
                {
                    precio = precioBasico + (precioBasico * 1.5);
                }
            }
            else
            {
                if (tipoHabitacion == "Simple")
                {
                    precio = precioBasico + (precioBasico * 0.4);
                }
                else if (tipoHabitacion == "Doble")
                {
                    precio = precioBasico + (precioBasico * 1.2);
                }
                else if (tipoHabitacion == "Triple")
                {
                    precio = precioBasico + (precioBasico * 1.9);
                }
            }
            //int dias = ((Reserva)((Propiedad)ListaReservas[0]).ListaReservas[0]).DiasAReservar();

            precio = precioServicios + precioxCamas;
            return precio;
        }
    }
}
