﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TP2_Lab
{
    [Serializable]
    public class Habitaciones:Propiedad
    {
        private int estrellas;
        private int tipoHabitacion;

        #region Propiedades
        public int Estrellas
        {
            get { return estrellas; }
            set { estrellas = value; }
        }

        public int TipoHabitacion
        {
            get { return tipoHabitacion; }
            set {  tipoHabitacion = value; }
        }
        #endregion
        public Habitaciones(int nro,int estrellas,double precio,string direccion,string localidad, bool[] servicios, int cantCamas,
            int tipoHabitacion, List<Image> pics) : base(nro,precio,direccion, localidad, cantCamas,servicios, pics)
        {
            this.estrellas = estrellas;
            this.tipoHabitacion = tipoHabitacion;
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
                if(tipoHabitacion == 1)
                {
                    precio = precioBasico;
                }
                else if(tipoHabitacion == 2)
                {
                    precio = precioBasico + (precioBasico * 0.8);
                }
                else if(tipoHabitacion == 3)
                {
                    precio = precioBasico + (precioBasico * 1.5);
                }
            }
            else
            {
                if (tipoHabitacion == 1)
                {
                    precio = precioBasico + (precioBasico * 0.4);
                }
                else if (tipoHabitacion == 2)
                {
                    precio = precioBasico + (precioBasico * 1.2);
                }
                else if (tipoHabitacion == 3)
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
