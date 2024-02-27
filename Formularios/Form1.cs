using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP2_Lab.Formularios;
using TP2_Lab.Properties;

namespace TP2_Lab
{
    public partial class Form1 : Form
    {
        Usuario usuario;
        private bool LoginSuccessful = true;
        private string miArchivo = "Datos.dat";
        private Propietario propietario;
        private Propiedad prop;
        private Sistema nuevoS;
        private Reserva miReserva;
        private int cantPropiedades = 0;
        private List<IExportable> listaDatos = new List<IExportable>();
        private FileStream archivo;
        private BinaryFormatter serDeser;
        private List<Image> images = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            Deserealizar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (nuevoS.CantUsuarios == 0)
            {
                usuario = new Administrador("Admin", "Admin");
                nuevoS.ListaUsuarios.Add(usuario);
                usuario = new Empleado("pancho", "fili");
                nuevoS.ListaUsuarios.Add(usuario);
            }
            FLogin vLogin = new FLogin();
            DialogResult presiono = vLogin.ShowDialog();
            if (presiono == DialogResult.OK)
            {
                usuario = new Usuario(vLogin.tbUsuario.Text, vLogin.tbContra.Text);
                nuevoS.ListaUsuarios.Sort();
                int pos = nuevoS.ListaUsuarios.BinarySearch(usuario);
                if (pos == 0 && usuario.Contra != nuevoS.ListaUsuarios[pos].Contra)
                    pos = -1;
                while (pos < 0)
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK);
                    presiono = vLogin.ShowDialog();
                    if (presiono == DialogResult.Cancel)
                    {
                        LoginSuccessful = false;
                        this.Close();
                    }
                    usuario = new Usuario(vLogin.tbUsuario.Text, vLogin.tbContra.Text);
                    pos = nuevoS.ListaUsuarios.BinarySearch(usuario);
                    if (pos == 0 && usuario.Contra != nuevoS.ListaUsuarios[pos].Contra)
                        pos = -1;
                }

                if (nuevoS.ListaUsuarios[pos] is Administrador)
                {
                    usuario = (Administrador)nuevoS.ListaUsuarios[pos];
                    MessageBox.Show("Uds es: Administrador");
                }
                else
                {
                    usuario = (Empleado)nuevoS.ListaUsuarios[pos];
                    MessageBox.Show("Uds es: Empleado");
                    btnAgregarPropiedad.Enabled = false;
                    btnEliminarPropiedad.Enabled = false;
                    crearUsuarioToolStripMenuItem.Enabled = false;
                    eliminarUsuarioToolStripMenuItem.Enabled = false;
                }
                RefreshDataGridView();
                RefrescarDGReservas();

                foreach (Propiedad propiedad in nuevoS.ListaPropiedad)
                    foreach (Reserva reserva in propiedad.ListaReservas)
                    {
                        listaDatos.Add(reserva);
                        listaDatos.Add(reserva.Cliente);
                    }
            }
            else if (presiono == DialogResult.Cancel)
            {
                LoginSuccessful = false;
                this.Close();
            }
            vLogin.Dispose();
        }

        #region Serializacion de datos
        private void Deserealizar()
        {
            try
            {
                if (File.Exists(miArchivo))
                {
                    archivo = new FileStream(miArchivo, FileMode.Open, FileAccess.Read);
                    serDeser = new BinaryFormatter();
                    nuevoS = (Sistema)serDeser.Deserialize(archivo);
                }
                else
                {
                    nuevoS = new Sistema();
                    MessageBox.Show("No se pudo encontrar el archivo, se generó una nueva empresa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error De Deserializacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    archivo.Dispose();
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginSuccessful)
            {
                try
                {
                    if (File.Exists(miArchivo)) File.Delete(miArchivo);

                    archivo = new FileStream(miArchivo, FileMode.CreateNew, FileAccess.Write);
                    serDeser = new BinaryFormatter();
                    serDeser.Serialize(archivo, nuevoS);
                    GuardarUsuarios(nuevoS.ListaUsuarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al serializar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (archivo != null)
                    {
                        archivo.Close();
                        archivo.Dispose();
                    }
                }
            }
        }

        private void GuardarUsuarios(List<Usuario> lstUsuarios)
        {
            string path = "usuarios.dat";
            using (FileStream fS = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serDeser = new BinaryFormatter();
                serDeser.Serialize(fS, lstUsuarios);
            }
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
                        List<Image> imagenCargadas = nuevaP.ListaImagenes;
                        if (nuevaP.rBCasas.Checked)
                        {
                            string nombre = CapitalizarPalabras(nuevaP.tBnombre.Text);
                            string apellido = CapitalizarPalabras(nuevaP.tBApellido.Text);
                            long dni = Convert.ToInt64(nuevaP.numDNI.Value);
                            propietario = new Propietario(nombre, apellido, dni);
                            int cantDiasPermitidos = Convert.ToInt32(nuevaP.numDiasPermitidos.Value);
                            if (nuevaP.rBcasaDia.Checked)
                            {
                                prop = new Casa(nro, cantDiasPermitidos, propietario, precio, direccion, localidad, cantCamas, servicios, imagenCargadas);
                            }
                            else if (nuevaP.rBcasaFinde.Checked)
                            {
                                prop = new CasaFindeSemana(nro, 0, propietario, precio, direccion, localidad, cantCamas, servicios, imagenCargadas);
                            }
                        }
                        if (nuevaP.rBHoteles.Checked)
                        {
                            int estrellas = Convert.ToInt32(nuevaP.numEstrellas.Text);
                            string tipoHabitacion = nuevaP.cBTipoHabitacion.ValueMember;
                            prop = new Habitaciones(nro, estrellas, precio, direccion, localidad, servicios, cantCamas, tipoHabitacion, imagenCargadas);
                        }
                        nuevoS.AgregarPropiedad(prop);
                        DGAgregarPropiedad(prop);
                        string auxLocalidad = nuevaP.tBlocalidad.Text;
                        ActualizarLocalidades(nuevoS.ListaPropiedad);
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

        private void btnModificarPropiedad_Click(object sender, EventArgs e)
        {
            FPropiedad nuevoFprop = new FPropiedad();
            if (DGPropiedades.SelectedRows.Count > 0)
            {
                Propiedad seleccionada = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value; //obtiene la propiedad seleccionada
                Propiedad buscada = nuevoS.BuscarPropiedad(seleccionada);

                if (buscada == null)
                {
                    MessageBox.Show("No se ha encontrado la propiedad");
                }
                else
                {
                    nuevoFprop.gbPropiedad.Enabled = false;
                    if (buscada is Habitaciones)
                    {
                        nuevoFprop.rBHoteles.Checked = true;
                        nuevoFprop.numEstrellas.Value = ((Habitaciones)buscada).Estrellas;
                        nuevoFprop.cBTipoHabitacion.ValueMember = ((Habitaciones)buscada).TipoHabitacion;
                    }
                    if (buscada is Casa)
                    {
                        nuevoFprop.rBcasaFinde.Enabled = false;
                        nuevoFprop.rBcasaDia.Enabled = false;
                        if (buscada is CasaFindeSemana)
                        {
                            nuevoFprop.rBcasaFinde.Checked = true;
                            nuevoFprop.gbCasaXDia.Enabled = false;
                        }
                        else
                            nuevoFprop.numDiasPermitidos.Value = ((Casa)buscada).DiasPermitidos;

                        string nomCompleto = ((Casa)buscada).Propietario;
                        string[] nomSeparado = nomCompleto.Split(',');
                        nuevoFprop.tBApellido.Text = nomSeparado[0];
                        nuevoFprop.tBnombre.Text = nomSeparado[1];
                        nuevoFprop.numDNI.Value = ((Casa)buscada).DNIpropietario;
                        nuevoFprop.gbPropietario.Enabled = false;
                    }

                    if (buscada.Servicios[0] == true) nuevoFprop.cbxCochera.Checked = true;
                    if (buscada.Servicios[1] == true) nuevoFprop.cbxPileta.Checked = true;
                    if (buscada.Servicios[2] == true) nuevoFprop.cbxWifi.Checked = true;
                    if (buscada.Servicios[3] == true) nuevoFprop.cbxLimpieza.Checked = true;
                    if (buscada.Servicios[4] == true) nuevoFprop.cbxDesayuno.Checked = true;
                    if (buscada.Servicios[5] == true) nuevoFprop.cbxMascotas.Checked = true;

                    nuevoFprop.numPrecio.Value = (decimal)buscada.PrecioBasico;

                    nuevoFprop.tBlocalidad.Text = buscada.Localidad;
                    nuevoFprop.tBdireccion.Text = buscada.Direccion;
                    nuevoFprop.numNro.Value = buscada.Nro;
                    nuevoFprop.numCamas.Value = buscada.CantCamas;



                    if (nuevoFprop.ShowDialog() == DialogResult.OK)
                    {
                        double precio = Convert.ToDouble(nuevoFprop.numPrecio.Value);

                        string localidad = nuevoFprop.tBlocalidad.Text;
                        string direccion = nuevoFprop.tBdireccion.Text;
                        int nro = Convert.ToInt32(nuevoFprop.numNro.Value);
                        int cantCamas = Convert.ToInt32(nuevoFprop.numCamas.Value);


                        buscada.Servicios[0] = nuevoFprop.cbxCochera.Checked == true ? true : false;
                        buscada.Servicios[1] = nuevoFprop.cbxPileta.Checked == true ? true : false;
                        buscada.Servicios[2] = nuevoFprop.cbxWifi.Checked == true ? true : false;
                        buscada.Servicios[3] = nuevoFprop.cbxLimpieza.Checked == true ? true : false;
                        buscada.Servicios[4] = nuevoFprop.cbxDesayuno.Checked == true ? true : false;
                        buscada.Servicios[5] = nuevoFprop.cbxMascotas.Checked == true ? true : false;

                        buscada.PrecioBasico = precio;

                        buscada.Localidad = localidad;
                        buscada.Direccion = direccion;
                        buscada.Nro = nro;
                        buscada.CantCamas = cantCamas;

                        if (buscada is Habitaciones)
                        {
                            ((Habitaciones)buscada).Estrellas = Convert.ToInt32(nuevoFprop.numEstrellas.Value);
                            ((Habitaciones)buscada).TipoHabitacion = nuevoFprop.cBTipoHabitacion.ValueMember;
                        }
                        if (buscada is Casa)
                        {
                            if (!(buscada is CasaFindeSemana))
                            {
                                ((Casa)buscada).DiasPermitidos = Convert.ToInt32(nuevoFprop.numDiasPermitidos.Value);
                            }
                        }
                        MessageBox.Show("Propiedad modificada correctamente");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar la propiedad");
                    }
                }
            }
            nuevoFprop.Dispose();
        }
        private void btnEliminarPropiedad_Click(object sender, EventArgs e)
        {
            if (DGPropiedades.Rows.Count > 0)
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
            RefreshDataGridView();
            ArrayList disponibles = new ArrayList();
            int cant = DGPropiedades.RowCount;
            for (int i = 0; i < cant; i++)
            {
                DataGridViewCell celda = DGPropiedades.Rows[i].Cells[0];
                if (celda.Value != null && celda.Value is Propiedad)
                {
                    // Reiniciar las variables en cada iteración
                    bool loc = true, fechas = true, huespedes = true, tipoHabitacion = true, tipoCasa = true;
                    Propiedad miProp = (Propiedad)celda.Value;

                    if (!string.IsNullOrWhiteSpace(cBLocalidad.Text) && !(miProp.Localidad == cBLocalidad.SelectedItem.ToString()))
                    {
                        loc = false;
                    }

                    TimeSpan dias = Calendar.SelectionEnd - Calendar.SelectionStart;
                    if (cbHabilitar.Checked)
                    {
                        if (nuevoS.Reservado(Calendar.SelectionStart, Calendar.SelectionEnd, miProp))
                            fechas = false;
                    }

                    if (numCantHuespedes.Value > 0 && numCantHuespedes.Value > miProp.CantCamas)
                        huespedes = false;

                    if (rbHotel.Checked)
                        tipoCasa = false;
                    if (rBcasa.Checked)
                        tipoHabitacion = false;

                    if (loc && fechas && huespedes && tipoHabitacion && miProp is Habitaciones)
                    {
                        disponibles.Add((Habitaciones)miProp);
                    }
                    else if (loc && fechas && huespedes && tipoCasa && miProp is Casa)
                    {
                        if (cbHabilitar.Checked)
                        {

                            if (dias.Days >= 1 && dias.Days <= 3 && miProp is CasaFindeSemana)
                            {
                                bool esFinde = true;
                                int j = 0;
                                while (j < dias.Days && esFinde)
                                {
                                    if (!(Calendar.SelectionEnd.DayOfWeek == DayOfWeek.Friday ||
                                        Calendar.SelectionEnd.DayOfWeek == DayOfWeek.Saturday ||
                                        Calendar.SelectionEnd.DayOfWeek == DayOfWeek.Sunday))
                                        esFinde = false;
                                    j++;
                                }
                                if (esFinde)
                                    disponibles.Add(miProp);
                            }
                        }
                        if (!cbHabilitar.Checked)
                            disponibles.Add(miProp);
                        else if (!(miProp is CasaFindeSemana))
                            disponibles.Add((Casa)miProp);

                    }

                }
            }
            if (disponibles.Count != nuevoS.ListaPropiedad.Count)
            {
                //limpiamos el datagrid
                DGPropiedades.Rows.Clear();

                foreach (Propiedad propiedad in disponibles)
                {
                    DGAgregarPropiedad(propiedad);
                }
            }
            rbHotel.Checked = false;
            rBcasa.Checked = false;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            FCliente nuevoC = new FCliente();
            if (nuevoC.ShowDialog() == DialogResult.OK)
            {
                string nombre;
                long dni;
                DateTime fechaNac = new DateTime();
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
                        fechaNac = nuevoC.dTfechaNac.Value;
                        Cliente miCliente = new Cliente(nombre, dni, fechaNac);
                        int huespedes = Convert.ToInt32(numCantHuespedes.Text);
                        DateTime inicio = Calendar.SelectionRange.Start;
                        DateTime fin = Calendar.SelectionRange.End;
                        TimeSpan duracionReserva = fin - inicio;
                        int numeroDias = duracionReserva.Days;
                        prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                        if (!nuevoS.Reservado(inicio, fin, prop) && prop != null)
                        {
                            if (prop is CasaFindeSemana &&
                                ((inicio.DayOfWeek == DayOfWeek.Friday || inicio.DayOfWeek == DayOfWeek.Saturday || inicio.DayOfWeek == DayOfWeek.Sunday) &&
                                (fin.DayOfWeek == DayOfWeek.Friday || fin.DayOfWeek == DayOfWeek.Saturday || fin.DayOfWeek == DayOfWeek.Sunday))
                                 || prop is Casa && !(prop is CasaFindeSemana) || prop is Habitaciones)
                            {
                                miReserva = new Reserva(miCliente, huespedes, inicio, fin);
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
                                listaDatos.Add(miReserva);
                                listaDatos.Add(miCliente);
                                nuevoS.ListaClientes.Add(miCliente);
                                RefrescarDGReservas();
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

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            fModificarReserva modificar = new fModificarReserva();
            try
            {
                string miCliente = DGReservas.SelectedRows[0].Cells[1].Value.ToString();
                Propiedad prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                int reservado = Convert.ToInt32(DGReservas.SelectedRows[0].Cells[2].Value);
                int i = 0;
                bool encontrado = false;
                while (!encontrado && i < prop.ListaReservas.Count)
                {
                    Reserva resv = prop.ListaReservas[i];
                    if (resv.Cliente.ToString() == miCliente && reservado == resv.NumeroReserva)
                    {
                        encontrado = true;
                        prop.ListaReservas.Remove(resv);
                        DialogResult dR = modificar.ShowDialog();
                        if (dR == DialogResult.OK)
                        {
                            DateTime fechaIn = modificar.dtFechaIn.Value;
                            DateTime fechaFin = modificar.dtFechaFin.Value;
                            int cantPersonas = Convert.ToInt32(modificar.numCant.Value);
                            bool ocupado = nuevoS.Reservado(fechaIn, fechaFin, prop);
                            if (!ocupado)
                            {
                                Reserva reservaActualizada = new Reserva(resv.Cliente, cantPersonas, fechaIn, fechaFin);
                                prop.ListaReservas.Add(reservaActualizada);

                                MessageBox.Show("Reserva actualizada con exito");
                            }
                            else
                            {
                                prop.ListaReservas.Add(resv);
                                MessageBox.Show("Fechas ya ocupadas");
                            }

                        }
                        if (dR == DialogResult.Cancel)
                        {
                            prop.ListaReservas.Add(resv);
                            MessageBox.Show("Modificación Cancelada");
                        }
                    }
                    i++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Esta propiedad no posee reservas");
            }



        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            if (DGReservas.Rows.Count > 0)
            {
                Reserva reserva = (Reserva)DGReservas.SelectedRows[0].Cells[0].Value;
                string nombre = reserva.Cliente.ToString();
                int nroReserv = reserva.NumeroReserva;
                Propiedad prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                int i = 0;
                bool eliminado = false;
                while (!eliminado && i < prop.ListaReservas.Count)
                {
                    Reserva resv = prop.ListaReservas[i];
                    string nombreCli = resv.Cliente.ToString();
                    if (nombreCli == nombre && resv.NumeroReserva == nroReserv)
                    {
                        prop.ListaReservas.Remove(resv);
                        MessageBox.Show("Reserva Eliminada", "Cancelación exitosa");
                        eliminado = true;
                    }
                    i++;
                }

                RefrescarDGReservas();
            }
            else
                MessageBox.Show("Seleccione la reserva a eliminar");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rBcasa.Enabled = true;
            RefreshDataGridView();

            cBLocalidad.Text = "";
            Calendar.SelectionRange.Start = DateTime.Now;
            Calendar.SelectionRange.End = DateTime.Now;
            numCantHuespedes.Value = 0;
        }



        #endregion

        #region MenuStrip



        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDatos(listaDatos, "ClientesReservas.dat");
            MessageBox.Show("Datos exportados correctamente", "Operacion exitosa");
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos CSV (.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportarCalendarioDeReservas(openFileDialog1.FileName);
            }
            MostrarCalendario(openFileDialog1.FileName);
        }

        private void MostrarCalendario(string path)
        {
            FReservaImportada vReservaImportada = new FReservaImportada();
            vReservaImportada.dGReservaImportada.RowHeadersVisible = false;
            openFileDialog1.Filter = "archivo de valores separados por coma (*.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream miArchivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(miArchivo);

                string renglon;
                while (!sr.EndOfStream)
                {
                    renglon = sr.ReadLine();
                    int filaIndex = vReservaImportada.dGReservaImportada.Rows.Add();
                    DataGridViewRow fila = vReservaImportada.dGReservaImportada.Rows[filaIndex];
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

        private void ImportarCalendarioDeReservas(string path)
        {
            List<Reserva> reservas = new List<Reserva>();
            FileStream archivo = null;
            StreamReader sR = null;
            try
            {
                archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                sR = new StreamReader(archivo);
                string linea;
                string[] datos;

                linea = sR.ReadLine();
                while (!sR.EndOfStream)
                {
                    linea = sR.ReadLine();
                    datos = linea.Split(';');
                    //int numReserva = Convert.ToInt32(datos[0]);
                    DateTime fechaI = Convert.ToDateTime(datos[1]);
                    DateTime fechaF = Convert.ToDateTime(datos[2]);
                    DateTime realizado = Convert.ToDateTime(datos[3]);
                    int cantidad = Convert.ToInt32(datos[4]);
                    long dni = Convert.ToInt64(datos[5]);

                    Cliente nuevoCliente = BuscarCliente(dni);
                    if (nuevoCliente != null)
                    {
                        Reserva nuevaRes = new Reserva(nuevoCliente, cantidad, fechaI, fechaF);
                        reservas.Add(nuevaRes);
                        MessageBox.Show("Se ha importado correctamente su calendario");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado una reserva");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato del archivo");
            }
            catch (IOException excep)
            {
                MessageBox.Show("Error en el archivo" + excep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido" + ex.Message);
            }
            finally
            {
                sR.Close();
                archivo.Dispose();
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value; ;
            saveFileDialog1.Filter = "Archivos CSV (.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportarCalendarioDeReservas(prop.ListaReservas, saveFileDialog1.FileName);
            }
        }

        private void ExportarCalendarioDeReservas(List<Reserva> listaReserva, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sW = new StreamWriter(fs);
                sW.WriteLine("nro Reserva;Fecha entrada;Fecha salida;Realizada;Cantidad de Huespedes;DNI cliente");
                foreach (Reserva r in listaReserva)
                {
                    sW.WriteLine(r.Exportar());
                }
                sW.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido" + ex.Message);
            }
            MessageBox.Show("Se ha exportado su calendario de reservas correctamente");
        }

        private Cliente BuscarCliente(long dni)
        {
            Cliente aBuscar = new Cliente("", dni, DateTime.Now);
            nuevoS.ListaClientes.Sort();
            int orden = nuevoS.ListaClientes.BinarySearch(aBuscar);

            if (orden >= 0)
            {
                aBuscar = nuevoS.ListaClientes[orden];
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }
            return aBuscar;
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***************************************************\n" +
                            "           Empresa de alquileres temporarios       \n" +
                            "***************************************************\n" +
                            "Versión: 1.0\n" +
                            "Autores: \n" +
                            "Acosta,Nicolas \n" +
                            "Belini, Augusto \n" +
                            "Ferrari, Nahuel \n" +
                            "Millen, Julian \n" +
                            "Descripción: Proyecto de alquileres temporarios que facilita la gestion de reservas para habitaciones de hotel, casas por dias y casas de fin de semana. Ofreciendo caracteristicas de filtrado como importacion/exportacion de datos en formato CSV, graficos estadisticos y una interfaz de usuario intuitiva y facil de usar para quien lo desee. \n" +
                            "Fecha de creación: Noviembre 2023\n" +
                            "*******************************",
                            "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaPaginaHTML = "Ayuda.html";

            // Combina la ruta de la página HTML con la ruta del directorio de ejecución del programa
            string rutaCompleta = Path.Combine(Application.StartupPath, "Resource", rutaPaginaHTML);

            // Verifica si el archivo existe antes de intentar abrirlo
            if (File.Exists(rutaCompleta))
            {
                FWeb web = new FWeb();
                web.wBrowser.Navigate(rutaCompleta);

                // Establece el tamaño de la ventana y muestra la forma
                web.Size = new Size(800, 600);
                web.ShowDialog();
            }
            else
            {
                MessageBox.Show("La página HTML no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistro fCambiarC = new FRegistro();
            fCambiarC.Text = "Cambiar Contraseña";
            fCambiarC.groupBox1.Visible = false;
            fCambiarC.lbUser.Text = "Contraseña actual";
            fCambiarC.lbContra.Text = "Contraseña nueva";
            if (fCambiarC.ShowDialog() == DialogResult.OK)
            {
                string actualContra = fCambiarC.tBuserN.Text;
                string nuevaContra = fCambiarC.tBcontraN.Text;
                CambiarContra(actualContra, nuevaContra);
            }
            fCambiarC.Dispose();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistro crearU = new FRegistro();
            if (usuario is Administrador)
            {
                if (crearU.ShowDialog() == DialogResult.OK)
                {
                    string nombre = crearU.tBuserN.Text;
                    string contra = crearU.tBcontraN.Text;
                    bool admin = crearU.rBadminN.Checked;
                    if (admin)
                    {
                        CrearUsuario(nombre, contra, admin);
                    }
                    else
                    {
                        CrearUsuario(nombre, contra, admin);
                    }
                }
            }
            crearU.Dispose();
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistro fEliminar = new FRegistro();
            if (usuario is Administrador)
            {
                fEliminar.tBcontraN.Visible = false;
                fEliminar.lbContra.Visible = false;
                fEliminar.groupBox1.Visible = false;
                if (fEliminar.ShowDialog() == DialogResult.OK)
                {
                    EliminarUsuario(fEliminar.tBuserN.Text);
                }
            }
            fEliminar.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTicket nuevoTicket = new FTicket();

            try
            {
                Reserva miReserva = (Reserva)DGReservas.SelectedRows[0].Cells[0].Value;
                Propiedad prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;

                if (miReserva != null && prop != null)
                {
                    if (prop is Habitaciones)
                        nuevoTicket.lBticket.Items.Add("\n\tNro de habitacion: " + prop.Nro.ToString() + "\n\tTipo de Habitacion" + ((Habitaciones)prop).TipoHabitacion);
                    else

                        nuevoTicket.lBticket.Items.Add("\n\tNro: " + prop.Nro);
                    nuevoTicket.lBticket.Items.Add("Datos de alojamiento: \n\tDireccion:" + prop.Direccion);
                    nuevoTicket.lBticket.Items.Add("\nPersonas admitidas: " + miReserva.CantPersonas);
                    nuevoTicket.lBticket.Items.Add("--------------------------------------------------------------------------------------");
                    nuevoTicket.lBticket.Items.Add("\nCliente: \n\tNombre: " + miReserva.Cliente + "\n\tDNI: " + miReserva.Cliente.DNI.ToString());
                    nuevoTicket.lBticket.Items.Add("Fecha de Nacimiento: " + miReserva.Cliente.FechaNacimiento.ToString("dd/MM/yyyy"));
                    nuevoTicket.lBticket.Items.Add("--------------------------------------------------------------------------------------");
                    nuevoTicket.lBticket.Items.Add("\nFecha y Hora reserva: " + miReserva.Realizado.ToString("U"));
                    nuevoTicket.lBticket.Items.Add("\nFecha CheckIn: " + miReserva.FechaEntrada.ToString("dd/MM/yyyy") + "\nFecha CheckOut: " + miReserva.FechaSalida.ToString("dd/MM/yyyy"));
                    nuevoTicket.lBticket.Items.Add("--------------------------------------------------------------------------------------");
                    nuevoTicket.lBticket.Items.Add("\nCosto por día: $" + prop.PrecioBasico.ToString());
                    nuevoTicket.lBticket.Items.Add("\nCosto total: $" + miReserva.PrecioFinal.ToString("00.0"));

                    Bitmap bitmap = new Bitmap(prop.Imagenes[0], new Size(125, 125));
                    nuevoTicket.pictureBox.Image = bitmap;
                    nuevoTicket.ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error, no hay ninguna reserva");
            }
        }


        private void barraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoDeBarras();
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficosSectores();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        static void ExportarDatos(List<IExportable> datos, string nombreArchivo)
        {
            FileStream archivoExportar = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sW = new StreamWriter(archivoExportar);

            foreach (IExportable dato in datos)
            {
                sW.WriteLine(dato.Exportar());
            }
            sW.Dispose();
            archivoExportar.Close();
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

            fila.Cells[0].Value = propiedad;
            fila.Cells[2].Value = propiedad.Localidad;
            fila.Cells[3].Value = propiedad.Direccion;
            fila.Cells[4].Value = propiedad.Nro;
            fila.Cells[6].Value = propiedad.PrecioBasico;
            fila.Cells[7].Value = propiedad.CantCamas;

            // Verificar el tipo de instancia y llenar las celdas correspondientes
            if (propiedad is Habitaciones)
            {
                fila.Cells[1].Value = "Habitaciones";
                fila.Cells[5].Value = "---";
                fila.Cells[8].Value = ((Habitaciones)propiedad).Estrellas;
                fila.Cells[9].Value = ((Habitaciones)propiedad).TipoHabitacion;
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

        private void cBTipoHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            rBcasa.Enabled = false;
        }


        private void RefreshDataGridView()
        {
            DGPropiedades.Rows.Clear();
            foreach (Propiedad propi in nuevoS.ListaPropiedad)
            {
                DGAgregarPropiedad(propi);
            }
            cantPropiedades = nuevoS.ListaPropiedad.Count;
            if (cantPropiedades > 0)
            {
                groupBox1.Enabled = true;
            }
            ActualizarLocalidades(nuevoS.ListaPropiedad);
        }
        private void ActualizarLocalidades(ArrayList propiedades)
        {
            foreach (Propiedad p in propiedades)
            {
                if (cBLocalidad.Items.Count == 0)
                {
                    cBLocalidad.Items.Add(p.Localidad);
                }
                else
                {
                    bool existe = false;
                    foreach (var item in cBLocalidad.Items)
                        if ((string)item.ToString() == p.Localidad)
                            existe = true;
                    if (!existe)
                        cBLocalidad.Items.Add(p.Localidad);
                }

            }
        }

        public void CrearUsuario(string nom, string contra, bool tipo)
        {
            Usuario nuevoUsuario;
            if (tipo)
                nuevoUsuario = new Administrador(nom, contra);
            else
                nuevoUsuario = new Empleado(nom, contra);
            nuevoS.ListaUsuarios.Sort();
            int pos = nuevoS.ListaUsuarios.BinarySearch(nuevoUsuario);
            if (pos < 0)
            {
                nuevoS.ListaUsuarios.Add(nuevoUsuario);
                MessageBox.Show("Usuario creado correctamente");
            }
            else
                MessageBox.Show("Nombre de usuario ocupado\n Intente con otro");
        }


        public Usuario EliminarUsuario(string nombre)
        {
            Usuario aEliminar = BuscarUsuario(nombre);

            if (aEliminar != null)
            {
                nuevoS.ListaUsuarios.Remove(aEliminar);
                MessageBox.Show("El usuario ha sido eliminado");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return aEliminar;
        }


        private void DGPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGPropiedades.Columns["VerImagen"].Index)
            {
                Propiedad propiedad = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;

                if (propiedad != null)
                {
                    // Obtener la lista de imágenes del objeto asociado
                    List<Image> images = propiedad.Imagenes;

                    // Haz algo con la lista de imágenes, como mostrarlas en una ventana
                    if (images != null && images.Count > 0)
                    {
                        ImageViewForm imageViewForm = new ImageViewForm(images); // Reemplaza ImageViewForm con el nombre de tu ventana de visualización de imágenes
                        imageViewForm.ShowDialog();
                    }
                }

                //// Mostrar la ventana de visualización de imágenes
                //ImageViewForm imageViewForm = new ImageViewForm(image);
                //imageViewForm.ShowDialog();
            }
        }

        private void DGPropiedades_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void DGPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefrescarDGReservas();

        }

        private void RefrescarDGReservas()
        {
            DGReservas.Rows.Clear();
            try
            {
                Propiedad propiedad = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                foreach (Reserva reserva in propiedad.ListaReservas)
                {
                    string cliente = reserva.Cliente.ToString();
                    string nroReserva = reserva.NumeroReserva.ToString();
                    string ingreso = reserva.FechaEntrada.ToString("U");
                    string egreso = reserva.FechaSalida.ToString("U");
                    string reservacion = reserva.Realizado.ToString("U");
                    string cantHuesped = reserva.CantPersonas.ToString();

                    int filaIndex = DGReservas.Rows.Add();
                    DataGridViewRow fila = DGReservas.Rows[filaIndex];

                    fila.Cells[0].Value = reserva;
                    fila.Cells[1].Value = cliente;
                    fila.Cells[2].Value = nroReserva;
                    fila.Cells[3].Value = ingreso;
                    fila.Cells[4].Value = egreso;
                    fila.Cells[5].Value = reservacion;
                    fila.Cells[6].Value = cantHuesped;
                }

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        public void CambiarContra(string actualC, string nuevaC)
        {
            nuevoS.ListaUsuarios.Sort();
            int pos = nuevoS.ListaUsuarios.BinarySearch(usuario);
            if (nuevoS.ListaUsuarios[pos].Contra == actualC)
            {
                nuevoS.ListaUsuarios[pos].Contra = nuevaC;
                MessageBox.Show("Contraseña cambiada correctamente");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        public Usuario BuscarUsuario(string nombre)
        {
            Usuario buscado = new Usuario(nombre, "");
            nuevoS.ListaUsuarios.Sort();
            int orden = nuevoS.ListaUsuarios.BinarySearch(buscado);
            if (orden >= 0)
            {
                buscado = nuevoS.ListaUsuarios[orden];
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return buscado;
        }

        private void cbHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            Calendar.Enabled = !Calendar.Enabled;
        }

        #endregion

        #region Ventana de Graficos

        private void GraficoDeBarras()
        {
            FGraficos stats2 = new FGraficos();
            // Crea el área del gráfico
            ChartArea areaReservas = new ChartArea();
            stats2.cGrafico.ChartAreas.Add(areaReservas);

            // Crear una serie para el gráfico de barras
            Series series = new Series("Huéspedes");
            series.ChartType = SeriesChartType.Bar;

            // Contador para la cantidad de huéspedes
            int[] contadorHuespedes = new int[5];

            // Inicializar todos los elementos en cero
            for (int i = 0; i < contadorHuespedes.Length; i++)
            {
                contadorHuespedes[i] = 0;
            }

            // Iterar a través de las reservas y contar la cantidad de huéspedes
            foreach (Propiedad propReserva in nuevoS.ListaPropiedad)
                foreach (Reserva reserva in propReserva.ListaReservas)
                {
                    int huesp = reserva.CantPersonas;
                    // Implementar contadores específicos para cada cantidad de huéspedes
                    if (huesp == 2)
                    {
                        contadorHuespedes[0]++;
                    }
                    else if (huesp == 3)
                    {
                        contadorHuespedes[1]++;
                    }
                    else if (huesp == 4)
                    {
                        contadorHuespedes[2]++;
                    }
                    else if (huesp == 5)
                    {
                        contadorHuespedes[3]++;
                    }
                    else
                    {
                        contadorHuespedes[4]++;
                    }
                }

            // Agrega los puntos de datos a la serie
            series.Points.AddXY("Huespedes 2", contadorHuespedes[0]);
            series.Points.AddXY("Huespedes 3", contadorHuespedes[1]);
            series.Points.AddXY("Huespedes 4", contadorHuespedes[2]);
            series.Points.AddXY("Huespedes 5", contadorHuespedes[3]);
            series.Points.AddXY("Huespedes 6 o mas", contadorHuespedes[4]);

            // Agregar la serie al gráfico
            stats2.cGrafico.Series.Add(series);

            stats2.cGrafico.Palette = ChartColorPalette.Excel; //colores de las barras

            stats2.ShowDialog();
        }

        private void GraficosSectores()
        {
            FGraficos stats = new FGraficos();
            // Crea el área del gráfico
            ChartArea areaReservas = new ChartArea();
            stats.cGrafico.ChartAreas.Add(areaReservas);

            // Limpia cualquier serie existente
            stats.cGrafico.Series.Clear();

            //stats.cGrafico.Width = 600;
            //stats.cGrafico.Height = 600;

            // Crea una serie para el gráfico de sectores
            Series serieReservas = new Series();
            serieReservas.ChartType = SeriesChartType.Pie;
            int casaFinde = 0,
                casaXDia = 0,
                habitacionHotel = 0;
            foreach (Propiedad lugar in nuevoS.ListaPropiedad)
            {
                if (lugar is CasaFindeSemana) { casaFinde++; }
                if (lugar is Casa) { casaXDia++; }
                if (lugar is Habitaciones) { habitacionHotel++; }
            }

            // Agrega los puntos de datos a la serie
            serieReservas.Points.AddXY("CasaPorDia", casaXDia);
            serieReservas.Points.AddXY("CasaFindeSemana", casaFinde);
            serieReservas.Points.AddXY("Habitaciones", habitacionHotel);


            // Cambia los colores específicos si es necesario
            serieReservas.Points[0].Color = Color.Red;
            serieReservas.Points[1].Color = Color.Green;
            serieReservas.Points[2].Color = Color.Blue;

            serieReservas.CustomProperties = "PieLabelStyle=Disabled";

            // Agrega la serie al gráfico
            stats.cGrafico.Series.Add(serieReservas);

            stats.ShowDialog();
        }
        #endregion

    }
}
