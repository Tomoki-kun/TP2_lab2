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
        List<Image> imagenes = new List<Image>();
        protected bool[] servicios = new bool[6];
        private string direccion;
        private string localidad;

        #region Propiedades
        public double PrecioBasico
        {
            get { return precioBasico; }
            set { precioBasico = value; }
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
        public List<Image> Imagenes
        {
            get { return imagenes; }
            set { imagenes = value; }
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
        public Propiedad(int nro,double precio,string direccion,string localidad, int cantCamas,bool[]servicios, List<Image> imagenes)
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
            Imagenes = imagenes;
        }

        public bool[] Servicios
        {
            get { return servicios; }
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
