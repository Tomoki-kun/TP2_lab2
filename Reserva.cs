using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace TP2_Lab
{
    [Serializable]
    public class Reserva : IComparable, IExportable
    {
        private Cliente cliente;
        private int numReserva;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private DateTime realizado;
        private double precioFinal;
        private int cantPersonas;
        public Reserva(Cliente cliente, int numReserva, int cantidad, DateTime fechaEntrada, DateTime fechaSalida)
        {
            Cliente = cliente;
            this.numReserva = numReserva;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            cantPersonas = cantidad;
        }
        public DateTime Realizado
        {
            get { return realizado; }
            set { realizado = value; }
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
        public double PrecioFinal
        {
            get { return precioFinal; }
            set { precioFinal = value; }
        }
        public int CompareTo(object obj)
        {
            return numReserva.CompareTo(((Reserva)obj).numReserva);
        }
        public override string ToString()
        {
            return Cliente + ";" + numReserva.ToString() + ";" + FechaEntrada.ToString() + ";" + 
                FechaSalida.ToString() + ";" + realizado.ToString() + ";" + cantPersonas.ToString();
        }

        public int CantPersonas
        {
            get { return cantPersonas; }
        }
        public void Comprobante(Propiedad prop)
        {
            string ss;
            if (prop is Habitaciones)
                ss = "\n\tNro de habitacion: " + prop.Nro.ToString() + "\n\tTipo de Habitacion" + ((Habitaciones)prop).TipoHabitacion;
            else
                ss = "\n\tNro: " + prop.Nro;
            string ret = "Datos de alojamiento: \n\tDireccion:" + prop.Direccion + ss + 
                "\nCantidad personas admitidos: " + cantPersonas + 
                "\nDatos Cliente: \n\tNombre: " + cliente + "\n\tDNI: " + cliente.DNI.ToString() +
                "\nFecha y Hora reserva: " + Realizado.ToString("U") +
                "\nFecha CheckIn: " + fechaEntrada +
                "\nFecha CheckOut: " + fechaSalida +
                "\nCosto por día: " + prop.PrecioBasico.ToString() +
                "\nCosto total: " + precioFinal;

            MessageBox.Show(ret);
        }
        public string Exportar()
        {
            return $"{numReserva},{cliente.DNI},{fechaEntrada},{fechaSalida}";
        }
    }
}
