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
        static int numStatic = 0;
        private int numReserva;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private DateTime realizado;
        private double precioFinal;
        private int cantPersonas;

        #region Propiedades
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
        public DateTime Realizado
        {
            get { return realizado; }
            set { realizado = value; }
        }
        public double PrecioFinal
        {
            get { return precioFinal; }
            set { precioFinal = value; }
        }
        public int CantPersonas
        {
            get { return cantPersonas; }
            set { cantPersonas = value; }
        }

        public int NumeroReserva
        {
            get { return numReserva; }
        }
        #endregion

        //Constructor
        public Reserva(Cliente cliente,  int cantidad, DateTime fechaEntrada, DateTime fechaSalida)
        {
            Cliente = cliente;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            cantPersonas = cantidad;
            numReserva= ++numStatic;
        }

        #region Metodos
        public int CompareTo(object obj)
        {
            return numReserva.CompareTo(((Reserva)obj).numReserva);
        }
        public override string ToString()
        {
            return numReserva + ";" + FechaEntrada.ToString() + ";" + 
                FechaSalida.ToString() + ";" + realizado.ToString() + ";" + cantPersonas.ToString() + ";" + cliente.DNI.ToString();
        }

        public string Comprobante(Propiedad prop)
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
            return ret;
        }
        public string Exportar()
        {
            return ToString();
        }
        #endregion
    }
}
