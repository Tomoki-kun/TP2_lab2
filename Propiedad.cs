using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Drawing;

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
        Image imagen;
        public List<Reserva> ListaReservas
        {
            get { return listaReservas; }
        }
        protected bool[] servicios = new bool[6];
        private string direccion;
        private string localidad;
        
        public Propiedad(int nro,double precio,string direccion,string localidad, int cantCamas,bool[]servicios, Image pic)
        {
            Nro = nro;
            PrecioBasico = precio;
            Direccion = direccion;
            CantCamas = cantCamas;
            Localidad = localidad;
            for(int i = 0; i < 6; i++)
            {
                this.servicios[i] = servicios[i];
            }
            Imagen = pic;
            
        }
        public abstract double CalcularPrecio();

        public Image Imagen
        {
            get { return imagen; }
            private set { imagen = value; }
        }
        public void AgregarReserva(Reserva miReserva)
        {
            listaReservas.Add(miReserva);
        }
        public int CantCamas
        {
            get { return cantCamas; }
            private set { cantCamas = value;}
        }
        public double PrecioBasico
        {
            get { return precioBasico; }
            private set { precioBasico = value;}
        }
        public string Localidad
        {
            get { return localidad; }
            private set { localidad = value; }
        }
        public int Nro
        {
            get { return nro; }
            private set { nro = value;}
        }
        public string Direccion
        {
            get { return direccion; }
            private set { direccion = value;}
        }

        public int CompareTo(object obj)
        {
            return this.direccion.CompareTo(((Propiedad)obj).direccion);
        }
    }
}
