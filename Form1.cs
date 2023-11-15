using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Lab.Properties;

namespace TP2_Lab
{
    public partial class Form1 : Form
    {
        string miArchivo = "Datos.dat";
        Propietario propietario;
        Propiedad prop;
        Sistema nuevoS = new Sistema();
        int cantPropiedades = 0;
        int cantReservas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Serializacion de datos
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(miArchivo))
            {
                FileStream archivo = new FileStream(miArchivo, FileMode.Open, FileAccess.Read);
                BinaryFormatter serUnser = new BinaryFormatter();
                nuevoS = (Sistema)serUnser.Deserialize(archivo);
                archivo.Close();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (File.Exists(miArchivo)) File.Delete(miArchivo);

            FileStream archivo = new FileStream(miArchivo, FileMode.CreateNew, FileAccess.Write);
            BinaryFormatter serUnser = new BinaryFormatter();
            serUnser.Serialize(archivo, nuevoS);
            archivo.Close();
        }
        #endregion

        #region Botones
        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            FPropiedad nuevaP = new FPropiedad();
            if (nuevaP.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (VerificarCamposCompletos(nuevaP))
                    {

                        bool[] servicios = new bool[6];
                        servicios[0] = nuevaP.cbxCochera.Checked;
                        servicios[1] = nuevaP.cbxPileta.Checked;
                        servicios[2] = nuevaP.cbxWifi.Checked;
                        servicios[3] = nuevaP.cbxLimpieza.Checked;
                        servicios[4] = nuevaP.cbxDesayuno.Checked;
                        servicios[5] = nuevaP.cbxMascotas.Checked;
                        string localidad = CapitalizarPalabras(nuevaP.tBlocalidad.Text);
                        string direccion = nuevaP.tBdireccion.Text;
                        int cantCamas = Convert.ToInt32(nuevaP.numCamas.Text);
                        double precio = Convert.ToDouble(nuevaP.numPrecio.Value);
                        int nro = Convert.ToInt32(nuevaP.numNro.Value);
                        Image imagen = Image.FromFile(nuevaP.RutaImagen);
                        if (nuevaP.rBCasas.Checked)
                        {
                            string nombre = CapitalizarPalabras(nuevaP.tBnombre.Text);
                            string apellido = CapitalizarPalabras(nuevaP.tBApellido.Text);
                            long dni = Convert.ToInt64(nuevaP.numDNI.Value);
                            propietario = new Propietario(nombre, apellido, dni);
                            int cantDiasPermitidos = Convert.ToInt32(nuevaP.numDiasPermitidos.Value);
                            if (nuevaP.rBcasaDia.Checked)
                            {
                                prop = new Casa(nro, cantDiasPermitidos, propietario, precio, direccion, localidad, cantCamas, servicios, imagen);
                            }
                            else if (nuevaP.rBcasaFinde.Checked)
                            {
                                prop = new CasaFindeSemana(nro, 0, propietario, precio, direccion, localidad, cantCamas, servicios, imagen);
                            }
                        }
                        if (nuevaP.rBHoteles.Checked)
                        {
                            int estrellas = Convert.ToInt32(nuevaP.numEstrellas.Text);
                            string tipoHabitacion = nuevaP.cBTipoHabitacion.ValueMember;
                            prop = new Habitaciones(nro, estrellas, precio, direccion, localidad, servicios, cantCamas, tipoHabitacion, imagen);
                        }
                        nuevoS.AgregarPropiedad(prop);
                        DGAgregarPropiedad(prop);
                        string auxLocalidad = nuevaP.tBlocalidad.Text;
                        if (cBLocalidad.Items.Count == 0)
                        {
                            cBLocalidad.Items.Add(auxLocalidad);
                        }
                        else
                        {
                            bool existe = false;
                            foreach (var item in cBLocalidad.Items)
                                if ((string)item.ToString() == auxLocalidad)
                                    existe = true;
                            if (existe)
                                cBLocalidad.Items.Add(auxLocalidad);
                        }
                        cantPropiedades++;
                        if (cantPropiedades > 0)
                        {
                            groupBox1.Enabled = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Todos los campos deben estar completos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarPropiedad_Click(object sender, EventArgs e)
        {
            if (DGPropiedades.Rows.Count > 1)
            {
                prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                Propiedad aEliminar = nuevoS.BuscarPropiedad(prop);

                if (aEliminar != null && DGPropiedades.SelectedRows.Count > 0)
                {
                    nuevoS.RemoverPropiedad(aEliminar); //deberia eliminar una propiedad buscada
                    DGPropiedades.Rows.RemoveAt(DGPropiedades.SelectedRows[0].Index); //deberia borrar la fila seleccionada
                    cantPropiedades--;
                    if (cantPropiedades == 0)
                    {
                        groupBox1.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione la propiedad que desea eliminar");
                }
            }
            else
                MessageBox.Show("no hay propiedades en la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool loc = true,
                 fechas = true,
                 huespedes = true,
                 tipoHabitacion = true;
            ArrayList disponibles = new ArrayList();
            if (!string.IsNullOrWhiteSpace(cBLocalidad.Text))
            {
                int cant = DGPropiedades.RowCount;
                for (int i = 0; i < cant - 1; i++)
                {
                    DataGridViewCell celda = DGPropiedades.Rows[i].Cells[0];
                    if (celda.Value != null && celda.Value is Propiedad)
                    {
                        Propiedad propiedad = (Propiedad)celda.Value;

                        if (!(propiedad.Localidad == cBLocalidad.SelectedItem.ToString()))
                        {
                            loc = false;
                        }

                        TimeSpan dias = Calendar.SelectionEnd - Calendar.SelectionStart;
                        if (dias.Days > 0)
                            if (nuevoS.Reservado(Calendar.SelectionStart, Calendar.SelectionEnd, propiedad))
                                fechas = false;

                        if (numCantHuespedes.Value > 0 && numCantHuespedes.Value > propiedad.CantCamas)
                            huespedes = false;

                        if (cBTipoHabitaciones.ValueMember != "" && cBTipoHabitaciones.ValueMember != ((Habitaciones)propiedad).TipoHabitacion)
                            tipoHabitacion = false;
                        if (loc && fechas && huespedes && tipoHabitacion)
                            disponibles.Add(propiedad);
                    }
                }
                if (disponibles.Count != nuevoS.CantPropiedades)
                {
                    DGPropiedades.Rows.Clear();

                    foreach (Propiedad propiedad in disponibles)
                    {
                        DGAgregarPropiedad(propiedad);
                    }
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            FCliente nuevoC = new FCliente();
            if (nuevoC.ShowDialog() == DialogResult.OK)
            {
                string nombre;
                long dni;
                if (nuevoC.tBnombreC.Text == "" || numCantHuespedes.Text == "")
                {
                    MessageBox.Show("Faltan datos por rellenar");
                }
                else
                {
                    try
                    {
                        nombre = nuevoC.tBnombreC.Text;
                        dni = (long)nuevoC.numDNI.Value;
                        Cliente miCliente = new Cliente(nombre, dni);
                        int huespedes = Convert.ToInt32(numCantHuespedes.Text);
                        DateTime inicio = Calendar.SelectionRange.Start;
                        DateTime fin = Calendar.SelectionRange.End;
                        TimeSpan duracionReserva = fin - inicio;
                        int numeroDias = duracionReserva.Days;
                        prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                        if (!nuevoS.Reservado(inicio, fin, prop) && prop != null)
                        {
                            if (prop is CasaFindeSemana && inicio.DayOfWeek == DayOfWeek.Friday && fin.DayOfWeek == DayOfWeek.Sunday
                                 || prop is Casa && numeroDias >= ((Casa)prop).DiasPermitidos || prop is Habitaciones)
                            {
                                Reserva miReserva = new Reserva(miCliente, cantReservas, huespedes, inicio, fin);
                                cantReservas++;
                                double costoFinal = 0;
                                if (prop is Habitaciones)
                                {
                                    costoFinal = (prop.CalcularPrecio() * numeroDias) + ((prop.CalcularPrecio() * numeroDias * 0.03));
                                }
                                if (prop is Casa)
                                {
                                    costoFinal = ((Casa)prop).DiasAReservar(numeroDias);

                                }
                                if (prop is CasaFindeSemana)
                                {
                                    costoFinal = prop.CalcularPrecio();
                                }
                                miReserva.PrecioFinal = costoFinal;
                                miReserva.Realizado = DateTime.Now;
                                miReserva.Comprobante(prop);
                                prop.AgregarReserva(miReserva);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo realizar la reserva", "ERROR");
                            }

                        }
                        else if (prop == null)
                        {
                            MessageBox.Show("Seleccione una propiedad");
                        }
                        else
                        {
                            MessageBox.Show("Fechas ya reservadas");
                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error de formato");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Error valores fuera de rango");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            nuevoC.Dispose();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            FCliente vCliente = new FCliente();
            if (vCliente.ShowDialog() == DialogResult.OK)
            {
                if (vCliente.tBnombreC.Text != "")
                {
                    string nombre;
                    long dni;
                    bool encontrada = false;
                    foreach (Propiedad prop in nuevoS.ListaPropiedad)
                    {
                        foreach (Reserva resv in prop.ListaReservas)
                        {
                            nombre = resv.Cliente.ToString();
                            dni = resv.Cliente.DNI;
                            if (nombre == vCliente.tBnombreC.Text && dni == (long)vCliente.numDNI.Value)
                            {
                                prop.ListaReservas.Remove(resv);
                                MessageBox.Show("Reserva Cancelada", "Cancelación exitosa");
                                encontrada = true;
                            }
                        }
                    }
                    if (!encontrada)
                        MessageBox.Show("No se encontró ninguna reserva de este cliente");
                }
                else
                    MessageBox.Show("Complete los campos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DGPropiedades.Rows.Clear();
            foreach (Propiedad propiedad in nuevoS.ListaPropiedad)
                DGAgregarPropiedad(propiedad);

            cBLocalidad.ValueMember = "";
            Calendar.SelectionRange.Start = DateTime.Now;
            Calendar.SelectionRange.End = DateTime.Now;
            numCantHuespedes.Value = 0;
            cBTipoHabitaciones.ValueMember = "";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string archivo = "misDatos.txt";
            saveFileDialog1.FileName = archivo;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog1.FileName;
                if (File.Exists(archivo)) File.Delete(archivo);
                FileStream miArchivo = new FileStream(archivo, FileMode.CreateNew, FileAccess.Write);
                StreamWriter sw = new StreamWriter(miArchivo);
                string linea;
                foreach (Propiedad prop in nuevoS.ListaPropiedad)
                {
                    foreach (Reserva resv in prop.ListaReservas)
                    {
                        linea = resv.ToString();
                        sw.WriteLine(linea);
                    }
                }
                sw.Close();
                miArchivo.Close();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FReservaImportada vReservaImportada = new FReservaImportada();
            vReservaImportada.dGReservaImportada.RowHeadersVisible = false;
            openFileDialog1.Filter = "archivo de valores separados por coma (*.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivo = openFileDialog1.FileName;
                FileStream miArchivo = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(miArchivo);

                string renglon;
                while (!sr.EndOfStream)
                {
                    renglon = sr.ReadLine();
                    int filaIndex = vReservaImportada.dGReservaImportada.Rows.Add();
                    DataGridViewRow fila = DGPropiedades.Rows[filaIndex];
                    string[] datos = renglon.Split(';');
                    for (int i = 0; i < datos.Length; i++)
                    {
                        fila.Cells[i].Value = datos[i];
                    }
                }
                vReservaImportada.ShowDialog();
                sr.Close();
                miArchivo.Close();
            }
        }
        #endregion

        #region Metodos del Form
        private bool VerificarCamposCompletos(FPropiedad form)
        {
            bool ret = true;
            if (string.IsNullOrWhiteSpace(form.tBdireccion.Text) && string.IsNullOrWhiteSpace(form.tBlocalidad.Text))
                ret = false;
            if ((string.IsNullOrWhiteSpace(form.tBApellido.Text) && string.IsNullOrWhiteSpace(form.tBnombre.Text) &&
                form.tBApellido.IsAccessible && form.tBnombre.IsAccessible) ||
                (string.IsNullOrEmpty(form.cBTipoHabitacion.ValueMember) && form.cBTipoHabitacion.IsAccessible))
                ret = false;

            return ret;
        }

        private string CapitalizarPalabras(string texto)
        {
            string[] palabras = texto.Split(' ');

            // Capitalizar la primera letra de cada palabra
            for (int i = 0; i < palabras.Length; i++)
            {
                if (!string.IsNullOrEmpty(palabras[i]))
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                }
            }

            // Unir las palabras nuevamente
            return string.Join(" ", palabras);
        }

        private void DGAgregarPropiedad(Propiedad propiedad)
        {
            int filaIndex = DGPropiedades.Rows.Add();
            DataGridViewRow fila = DGPropiedades.Rows[filaIndex];
            Bitmap bitmap;

            fila.Cells[0].Value = propiedad;
            fila.Cells[2].Value = propiedad.Localidad;
            fila.Cells[3].Value = propiedad.Direccion;
            fila.Cells[4].Value = propiedad.Nro;
            fila.Cells[6].Value = propiedad.PrecioBasico;
            fila.Cells[7].Value = propiedad.CantCamas;
            if (propiedad.Imagen != null)
            {
                bitmap = new Bitmap(propiedad.Imagen, 100, 100);
                fila.Cells[11].Value = bitmap;
            }


            // Verificar el tipo de instancia y llenar las celdas correspondientes
            if (propiedad is Habitaciones)
            {
                fila.Cells[1].Value = "Habitaciones";
                fila.Cells[5].Value = "---";
                fila.Cells[8].Value = ((Habitaciones)propiedad).Estrellas;
                fila.Cells[9].Value = ((Habitaciones)propiedad).TipoHabitacion;
                fila.Cells[11].Value = propiedad.Imagen;
            }
            else if (propiedad is Casa)
            {
                if (propiedad is CasaFindeSemana)
                {
                    fila.Cells[1].Value = "Casa Fin de Semana";
                    fila.Cells[3].Value = "---";
                }
                else
                {
                    fila.Cells[1].Value = "Casa Por Dia";
                    fila.Cells[5].Value = ((Casa)propiedad).DiasPermitidos;
                }
                fila.Cells[8].Value = "---";
                fila.Cells[9].Value = "---";
                fila.Cells[10].Value = ((Casa)propiedad).Propietario;
            }
        }
        #endregion

    }
}
