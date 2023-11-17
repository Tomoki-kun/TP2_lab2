using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TP2_Lab
{
    [Serializable]
    public abstract class Propiedad : IComparable
    {
        protected double precioBasico;
        protected int cantCamas;
        protected bool estado;
        protected int nro;
        private List<Reserva> listaReservas=new List<Reserva>();
        public List<Reserva> ListaReservas
        {
            get { return listaReservas; }
        }
        protected bool[] servicios = new bool[6];
        protected string direccion;
        protected string localidad;
        
        public Propiedad(int nro,double precio,string direccion,string localidad, int cantCamas,bool[]servicios)
        {
            this.nro = nro;
            this.precioBasico = precio;
            this.direccion = direccion;
            this.cantCamas = cantCamas;
            this.localidad = localidad;
            for(int i = 0; i < 6; i++)
            {
                this.servicios[i] = servicios[i];
            }
            
        }
        public abstract double CalcularPrecio();
        public void AgregarReserva(Reserva miReserva)
        {
            listaReservas.Add(miReserva);
        }

        public int CantCamas
        {
            get { return cantCamas; }
        }
        public double PrecioBasico
        {
            get { return precioBasico; }
        }
        public string Localidad
        {
            get { return localidad; }
        }
        public int Nro
        {
            get { return nro; }
        }
        public string Direccion
        {
            get { return direccion; }
        }

        public int CompareTo(object obj)
        {
            return this.direccion.CompareTo(((Propiedad)obj).direccion);
        }
    }
}
