using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TP2_Lab
{
    [Serializable]
    public class Reserva : IComparable
    {
        //List<Cliente> listaCliente=new List<Cliente>();
        //private ArrayList listaCliente = new ArrayList();

        private Cliente cliente;
        private int numReserva;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private int cantPersonas;
        public Reserva(Cliente cliente, int numReserva, int cantidad, DateTime fechaEntrada, DateTime fechaSalida)
        {
            Cliente = cliente;
            this.numReserva = numReserva;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            cantPersonas = cantidad;
        }
        public Cliente Cliente
        {
            get { return cliente; }
            private set { cliente = value; }
        }
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }
        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        public int DiasAReservar(DateTime inicio, DateTime fin)
        {
            TimeSpan duracionReserva = fin - inicio;
            int numeroDias = duracionReserva.Days;
            return numeroDias;
        }
        public int CompareTo(object obj)
        {
            return numReserva.CompareTo(((Reserva)obj).numReserva);
        }
    }
}
