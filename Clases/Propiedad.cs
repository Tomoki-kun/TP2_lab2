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
        Image imagen2;
        protected bool[] servicios = new bool[6];
        private string direccion;
        private string localidad;

        #region Propiedades
        public double PrecioBasico
        {
            get { return precioBasico; }
            private set { precioBasico = value; }
        }
        public int CantCamas
        {
            get { return cantCamas; }
           set { cantCamas = value; }
        }
        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        public List<Reserva> ListaReservas
        {
            get { return listaReservas; }
        }
        public Image Imagen
        {
            get { return imagen; }
            private set { imagen = value; }
        }

        public Image Imagen2
        {
            get { return imagen2; }
            private set { imagen2 = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        #endregion
        public Propiedad(int nro,double precio,string direccion,string localidad, int cantCamas,bool[]servicios, Image pic, Image pic2)
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
            imagen2 = pic2;
        }

        #region Metodos
        public abstract double CalcularPrecio();

        public void AgregarReserva(Reserva miReserva)
        {
            listaReservas.Add(miReserva);
        }

        public int CompareTo(object obj)
        {
            return this.direccion.CompareTo(((Propiedad)obj).direccion);
        }
        #endregion
    }
}
