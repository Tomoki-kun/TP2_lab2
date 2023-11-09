using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace TP2_Lab
{
    [Serializable]
    public class Sistema
    {
        private ArrayList listaPropiedad;
        public ArrayList ListaPropiedad
        {
            get { return listaPropiedad; }
        }

        public int CantPropiedades
        {
            get { return listaPropiedad.Count; }
        }
        public Sistema()
        {
            listaPropiedad = new ArrayList();
        }

        public void AgregarPropiedad(Propiedad miPropiedad)
        {
            listaPropiedad.Add(miPropiedad);
        }
        public void RemoverPropiedad(Propiedad miPropiedad)
        {
            Propiedad aux = BuscarPropiedad(miPropiedad);
            if (aux != null)
            {
                listaPropiedad.Remove(aux);
            }
        }
        public Propiedad BuscarPropiedad(Propiedad miPropiedad)
        {
            Propiedad aux = null;
            listaPropiedad.Sort();
            int pos = listaPropiedad.BinarySearch(miPropiedad);
            if(pos >= 0)
                aux = (Propiedad)listaPropiedad[pos];
            return aux;
        }
        private Reserva BuscarReserva(Propiedad miPropiedad,Reserva miReserva)
        {
            int pos = miPropiedad.ListaReservas.BinarySearch(miReserva);
            Reserva aux = null;
            if(pos >= 0)
                aux = (Reserva)listaPropiedad[pos];
            return aux;
        }
        public void CancelarReserva(Propiedad miPropiedad, Reserva miReserva)
        {
            Reserva aux = BuscarReserva(miPropiedad, miReserva);
            if (aux != null)
            {
                listaPropiedad.Remove(aux);
                MessageBox.Show("Reserva eliminada");
            }
            else
                MessageBox.Show("Reserva no encontrada");
        }
        public bool Reservado(DateTime fechaIngreso, DateTime fechaEgreso, Propiedad miPropiedad)
        {
            bool ret = false;
            int i = 0;
            int cant = miPropiedad.ListaReservas.Count;
            List<Reserva> lista = miPropiedad.ListaReservas;
            while (ret == false && i < cant)
            {
                if (lista[i].FechaEntrada >= fechaIngreso && lista[i].FechaEntrada <= fechaEgreso ||
                    lista[i].FechaSalida >= fechaIngreso && lista[i].FechaSalida <= fechaEgreso)
                    ret = true;
                i++;
            }
            return ret;
        }
    }
}
