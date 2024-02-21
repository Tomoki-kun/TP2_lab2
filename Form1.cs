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
using TP2_Lab.Properties;

namespace TP2_Lab
{
    public partial class Form1 : Form
    {
        private string miArchivo = "Datos.dat";
        private Propietario propietario;
        private Propiedad prop;
        private Sistema nuevoS = new Sistema();
        private Reserva miReserva;
        private int cantPropiedades = 0,
            cantReservas = 0,
            reservasCasaDia = 0,
            reservasCasaFinde = 0,
            reservasHabitaciones = 0;
        private List<IExportable> listaDatos = new List<IExportable>();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Cliente> listaClientes = new List<Cliente>();
        Usuario admin = new Administrador("Admin", "Admin");
        FileStream archivo;
        BinaryFormatter serUnser;
        public Form1()
        {
            InitializeComponent();
            listaUsuarios.Add(admin);
            FLogin vLogin = new FLogin();
            Usuario usuario;
            vLogin.ShowDialog();

            if (vLogin.rbAdmin.Checked)
                usuario = new Administrador(vLogin.tbUsuario.Text, vLogin.tbContra.Text);
            else
                usuario = new Empleado(vLogin.tbUsuario.Text, vLogin.tbContra.Text);
            if(usuario is Administrador && !EsAdministrador(vLogin.tbUsuario.Text))
            {
                MessageBox.Show("No puede ingresar como usuario administrador");
                vLogin.Dispose();
            }
            if(usuario is Empleado)
            {
                btnAgregarPropiedad.Enabled = false;
                btnEliminarPropiedad.Enabled = false;
                crearUsuarioToolStripMenuItem.Enabled = false;
                eliminarUsuarioToolStripMenuItem.Enabled = false;
            }
            listaUsuarios.Add(usuario);
            listaUsuarios.Sort();
            int pos = listaUsuarios.BinarySearch(usuario);
            while (pos < 0 || (pos >= 0 && ((usuario is Administrador && listaUsuarios[pos] is Empleado) || (usuario is Empleado && listaUsuarios[pos] is Administrador))))
            {
                vLogin.ShowDialog();
                if (vLogin.rbAdmin.Checked)
                    usuario = new Administrador(vLogin.tbUsuario.Text, vLogin.tbContra.Text);
                
                else
                    usuario = new Empleado(vLogin.tbUsuario.Text, vLogin.tbContra.Text);      
                listaDatos.Sort();
            }

            vLogin.Dispose();
            Deserealizar();
            RefreshDataGridView();
        }

        #region Serializacion de datos
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void Deserealizar()
        {
            try
            {
                if (File.Exists(miArchivo))
                {
                    archivo = new FileStream(miArchivo, FileMode.Open, FileAccess.Read);
                    serUnser = new BinaryFormatter();
                    nuevoS = (Sistema)serUnser.Deserialize(archivo);
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
            try
            {
                if (File.Exists(miArchivo)) File.Delete(miArchivo);

                archivo = new FileStream(miArchivo, FileMode.CreateNew, FileAccess.Write);
                serUnser = new BinaryFormatter();
                serUnser.Serialize(archivo, nuevoS);
                GuardarUsuarios(listaUsuarios);
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

        private void GuardarUsuarios(List<Usuario> lstUsuarios)
        {
            string path = "usuarios.dat";
            using (FileStream fS = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serUnser = new BinaryFormatter();
                serUnser.Serialize(fS, lstUsuarios);
            }
        }

        private void CargarUsuarios()
        {
            string path = "usuarios.dat";
            if (File.Exists(path))
            {
                FileStream fS = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter bF = new BinaryFormatter();
                listaUsuarios = (List<Usuario>)bF.Deserialize(fS);
                fS.Close();
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
                        Image imagen = Image.FromFile(nuevaP.RutaImagen);
                        Image imagen2 = Image.FromFile(nuevaP.RutaImagen2);
                        if (nuevaP.rBCasas.Checked)
                        {
                            string nombre = CapitalizarPalabras(nuevaP.tBnombre.Text);
                            string apellido = CapitalizarPalabras(nuevaP.tBApellido.Text);
                            long dni = Convert.ToInt64(nuevaP.numDNI.Value);
                            propietario = new Propietario(nombre, apellido, dni);
                            int cantDiasPermitidos = Convert.ToInt32(nuevaP.numDiasPermitidos.Value);
                            if (nuevaP.rBcasaDia.Checked)
                            {
                                prop = new Casa(nro, cantDiasPermitidos, propietario, precio, direccion, localidad, cantCamas, servicios, imagen,imagen2);
                            }
                            else if (nuevaP.rBcasaFinde.Checked)
                            {
                                prop = new CasaFindeSemana(nro, 0, propietario, precio, direccion, localidad, cantCamas, servicios, imagen,imagen2);
                            }
                        }
                        if (nuevaP.rBHoteles.Checked)
                        {
                            int estrellas = Convert.ToInt32(nuevaP.numEstrellas.Text);
                            string tipoHabitacion = nuevaP.cBTipoHabitacion.ValueMember;
                            prop = new Habitaciones(nro, estrellas, precio, direccion, localidad, servicios, cantCamas, tipoHabitacion, imagen,imagen2);
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

                if(buscada == null)
                {
                    MessageBox.Show("No se ha encontrado la propiedad");
                }
                if(nuevoFprop.ShowDialog() == DialogResult.OK)
                {
                    if (buscada != null)
                    {
                        string direccion = nuevoFprop.tBdireccion.Text;
                        string localidad = nuevoFprop.tBlocalidad.Text;
                        int nro = Convert.ToInt32(nuevoFprop.numNro.Value);
                        int cantCamas = Convert.ToInt32(nuevoFprop.numCamas.Value);

                        buscada.Nro = nro;
                        buscada.Localidad = localidad;
                        buscada.CantCamas = cantCamas;
                        buscada.Direccion = direccion;

                        DGPropiedades.Refresh();
                    }
                }
                MessageBox.Show("Propiedad modificada correctamente");
                
            }
            else
            {
                MessageBox.Show("No se ha podido modificar la propiedad");
            }
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
            //bool loc = true,
            //fechas = true,
            //huespedes = true,
            //tipoHabitacion = true;
            cBTipoHabitaciones.Enabled = true;
            rBcasa.Checked = false;
            ArrayList disponibles = new ArrayList();
            if (!string.IsNullOrWhiteSpace(cBLocalidad.Text))
            {
                int cant = DGPropiedades.RowCount;
                for (int i = 0; i < cant - 1; i++)
                {
                    DataGridViewCell celda = DGPropiedades.Rows[i].Cells[0];
                    if (celda.Value != null && celda.Value is Propiedad)
                    {
                        // Reiniciar las variables en cada iteración
                        bool loc = true, fechas = true, huespedes = true, tipoHabitacion = true, tipoCasa=true;
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
                        if (rBcasa.Checked)
                         tipoCasa = false;

                        if (loc && fechas && huespedes && tipoHabitacion)
                        {
                            disponibles.Add(propiedad);
                        }
                        else if (loc && fechas && huespedes && tipoCasa)
                        {
                            disponibles.Add((Casa)propiedad);
                            if(dias.Days== 1 || dias.Days==2 || dias.Days==3)
                            {
                                disponibles.Add((CasaFindeSemana)propiedad);
                            }
                        }
                    }

                }
                if (disponibles.Count != nuevoS.CantPropiedades)
                {
                    //limpiamos el datagrid
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
                        Cliente miCliente = new Cliente(nombre, dni,fechaNac);
                        int huespedes = Convert.ToInt32(numCantHuespedes.Text);
                        DateTime inicio = Calendar.SelectionRange.Start;
                        DateTime fin = Calendar.SelectionRange.End;
                        TimeSpan duracionReserva = fin - inicio;
                        int numeroDias = duracionReserva.Days;
                        prop = (Propiedad)DGPropiedades.SelectedRows[0].Cells[0].Value;
                        if (!nuevoS.Reservado(inicio, fin, prop) && prop != null)
                        {
                            if (prop is CasaFindeSemana && inicio.DayOfWeek == DayOfWeek.Friday && fin.DayOfWeek == DayOfWeek.Sunday
                                 || prop is Casa && !(prop is CasaFindeSemana) && numeroDias >= ((Casa)prop).DiasPermitidos || prop is Habitaciones)
                            {
                                miReserva = new Reserva(miCliente, cantReservas, huespedes, inicio, fin);
                                cantReservas++;
                                double costoFinal = 0;
                                if (prop is Habitaciones)
                                {
                                    costoFinal = (prop.CalcularPrecio() * numeroDias) + ((prop.CalcularPrecio() * numeroDias * 0.03));
                                    reservasHabitaciones++;
                                }
                                if (prop is Casa)
                                {
                                    costoFinal = ((Casa)prop).DiasAReservar(numeroDias);
                                    reservasCasaDia++;
                                }
                                if (prop is CasaFindeSemana)
                                {
                                    costoFinal = prop.CalcularPrecio();
                                    reservasCasaFinde++;
                                }
                                miReserva.PrecioFinal = costoFinal;
                                miReserva.Realizado = DateTime.Now;
                                miReserva.Comprobante(prop);
                                prop.AgregarReserva(miReserva);
                                listaDatos.Add(miReserva);
                                listaDatos.Add(miCliente);
                                listaClientes.Add(miCliente);
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
            FCliente mCliente = new FCliente();
            fModificarReserva modificar = new fModificarReserva();
            mCliente.dTfechaNac.Visible = false;
            mCliente.numDNI.Visible = false;
            if (mCliente.ShowDialog() == DialogResult.OK)
            {
                if(mCliente.tBnombreC.Text != "")
                {
                    string nombre;
                    bool encontrada = false;
                    foreach(Propiedad prop in nuevoS.ListaPropiedad)
                    {
                        foreach(Reserva resv in prop.ListaReservas)
                        {
                            nombre = resv.Cliente.ToString();
                            if(nombre== mCliente.tBnombreC.Text)
                            {
                                encontrada = true;
                                if (modificar.ShowDialog() == DialogResult.OK)
                                {
                                    DateTime fechaIn = modificar.dtFechaIn.Value;
                                    DateTime fechaFin = modificar.dtFechaFin.Value;
                                    int cantPersonas = Convert.ToInt32(modificar.tBcantidad.Text);
                                    resv.CantPersonas = cantPersonas;
                                    resv.FechaEntrada = fechaIn;
                                    resv.FechaSalida = fechaFin;
                                }
                                MessageBox.Show("Reserva actualizada con exito");
                            }
                        }
                    }
                    if (!encontrada)
                    {
                        MessageBox.Show("Reserva no encontrada");
                    }
                }
            }

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
                                if (prop is Habitaciones) reservasHabitaciones--;
                                if (prop is Casa) reservasCasaDia--;
                                if (prop is CasaFindeSemana) reservasCasaFinde--;
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
            rBcasa.Enabled = true;
            DGPropiedades.Rows.Clear();
            int cant = nuevoS.ListaPropiedad.Count;
            for (int i = 0; i < cant; i++)
            {
                Propiedad propiedad = (Propiedad)nuevoS.ListaPropiedad[i];
                DGAgregarPropiedad(propiedad);

            }

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
        #endregion

        #region MenuStrip

        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDatos(listaDatos, miArchivo);
            MessageBox.Show("Datos exportados correctamente", "Operacion exitosa");
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos CSV (.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportarCalendarioDeReservas(openFileDialog1.FileName);
            }
        }

        private void ImportarCalendarioDeReservas(string path)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                FileStream archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sR = new StreamReader(archivo);
                string linea;
                string[] datos;

                while (!sR.EndOfStream)
                {
                    linea = sR.ReadLine();
                    datos = linea.Split(';');
                    int numReserva = Convert.ToInt32(datos[0]);
                    int cantidad = Convert.ToInt32(datos[1]);
                    long dni = Convert.ToInt64(datos[2]);
                    DateTime fechaI = Convert.ToDateTime(datos[3]);
                    DateTime fechaF = Convert.ToDateTime(datos[4]);

                    Cliente nuevoCliente = BuscarCliente(dni);
                    if(nuevoCliente != null)
                    {
                        reservas.Add(new Reserva(nuevoCliente, numReserva,cantidad, fechaI, fechaF));
                        MessageBox.Show("Se ha importado correctamente su calendario");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado una reserva");
                    }
                }
                sR.Close();
                archivo.Dispose();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato del archivo");
            }
            catch(IOException excep)
            {
                MessageBox.Show("Error en el archivo" + excep);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error desconocido" + ex.Message);
            }
        }

        private Cliente BuscarCliente(long dni)
        {
            Cliente aBuscar = new Cliente("", dni, DateTime.Now);
            listaClientes.Sort();
            int orden = listaClientes.BinarySearch(aBuscar);

            if (orden >= 0)
            {
                aBuscar = listaClientes[orden];
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }
            return aBuscar;
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos CSV (.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportarCalendarioDeReservas(prop.ListaReservas, saveFileDialog1.FileName);
            }
        }

        private void ExportarCalendarioDeReservas(List<Reserva> listaReserva,string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sW = new StreamWriter(fs);

                foreach(Reserva r in listaReserva)
                {
                    sW.WriteLine(r.Exportar());
                }
                sW.Close();
                fs.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error desconocido" + ex.Message);
            }
            MessageBox.Show("Se ha exportado su calendario de reservas correctamente");
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
            if (fCambiarC.ShowDialog() == DialogResult.OK)
            {
                string nombre = fCambiarC.tBuserN.Text;
                string nuevaContra = fCambiarC.tBcontraN.Text;
                CambiarContra(nombre, nuevaContra);
                MessageBox.Show("Contraseña cambiada correctamente");
            }
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistro crearU = new FRegistro();
            if (admin is Administrador)
            {
                if (crearU.ShowDialog() == DialogResult.OK)
                {
                    string nombre = crearU.tBuserN.Text;
                    string contra = crearU.tBcontraN.Text;
                    bool tipoA = crearU.rBadminN.Checked;
                    bool tipoC = crearU.rBempleadoN.Checked;
                    if (tipoA)
                    {
                        CrearUsuarioAdmin(nombre, contra, tipoA);
                    }
                    else if (tipoC)
                    {
                        CrearUsuarioEmpleado(nombre, contra, tipoC);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el usuario");
                    }
                    MessageBox.Show("Usuario creado correctamente");
                }
            }
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegistro fEliminar = new FRegistro();
            if (admin is Administrador)
            {
                fEliminar.tBcontraN.Enabled = false;
                fEliminar.groupBox1.Enabled = false;
                if (fEliminar.ShowDialog() == DialogResult.OK)
                {
                    fEliminar.tBcontraN.Enabled = false;
                    fEliminar.groupBox1.Enabled = false;
                    string nombre = fEliminar.tBuserN.Text;
                    EliminarUsuario(nombre);
                }
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTicket nuevoTicket = new FTicket();
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
                nuevoTicket.pictureBox1.Image = prop.Imagen;
                nuevoTicket.ShowDialog();
            }
            else
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
            Bitmap bitmap, bitmap2;

            fila.Cells[0].Value = propiedad;
            fila.Cells[2].Value = propiedad.Localidad;
            fila.Cells[3].Value = propiedad.Direccion;
            fila.Cells[4].Value = propiedad.Nro;
            fila.Cells[6].Value = propiedad.PrecioBasico;
            fila.Cells[7].Value = propiedad.CantCamas;
            bitmap = new Bitmap(propiedad.Imagen, 50, 25);
            fila.Cells[11].Value = bitmap;
            if (propiedad.Imagen2 != null)
            {
                bitmap2 = new Bitmap(propiedad.Imagen2, 50, 25);
                fila.Cells[12].Value = bitmap2;
            }
            // Verificar el tipo de instancia y llenar las celdas correspondientes
            if (propiedad is Habitaciones)
            {
                fila.Cells[1].Value = "Habitaciones";
                fila.Cells[5].Value = "---";
                fila.Cells[8].Value = ((Habitaciones)propiedad).Estrellas;
                fila.Cells[9].Value = ((Habitaciones)propiedad).TipoHabitacion;
                fila.Cells[11].Value = propiedad.Imagen;
                fila.Cells[12].Value = propiedad.Imagen2;
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

        private void rBcasa_CheckedChanged(object sender, EventArgs e)
        {
            if (rBcasa.Checked)
            {
                cBTipoHabitaciones.Enabled = false;
            }
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

        public Usuario CrearUsuarioAdmin(string nom, string contra, bool tipo)
        {
            Usuario nuevoUsuario;
            if (tipo)
            {
                nuevoUsuario = new Administrador(nom, contra);
                listaUsuarios.Add(nuevoUsuario);
            }
            else
            {
                throw new Exception("no se pudo crear el usuario");
            }
            return nuevoUsuario;
        }

        public Usuario CrearUsuarioEmpleado(string nom, string contra, bool tipo)
        {
            Usuario nuevoUsu;
            if (tipo)
            {
                nuevoUsu = new Empleado(nom, contra);
                listaUsuarios.Add(nuevoUsu);
            }
            else
            {
                throw new Exception("no se pudo crear el usuario");
            }
            return nuevoUsu;
        }


        public Usuario EliminarUsuario(string nombre)
        {
            Usuario aEliminar = BuscarUsuario(nombre);

            if (aEliminar != null)
            {
                listaUsuarios.Remove(aEliminar);
                MessageBox.Show("El usuario ha sido eliminado");
            }
            else
            {
                throw new Exception("Usuario no encontrado");
            }
            return aEliminar;
        }

        public Usuario CambiarContra(string nombre, string nuevaC)
        {
            Usuario miUsu = BuscarUsuario(nombre);
            if (miUsu != null)
            {
                miUsu.Contra = nuevaC;
                MessageBox.Show("Contraseña cambiada correctamente");
            }
            else
            {
                throw new Exception("Usuario no encontrado");
            }
            return miUsu;
        }

        public Usuario BuscarUsuario(string nombre)
        {
            Usuario buscado = new Usuario(nombre, "");
            listaUsuarios.Sort();
            int orden = listaUsuarios.BinarySearch(buscado);
            if (orden >= 0)
            {
                buscado = listaUsuarios[orden];
            }
            else
            {
                throw new Exception("Usuario no encontrado");
            }
            return buscado;
        }

        public bool EsAdministrador(string nombre)
        {
            bool esAdmin = false;
            Usuario admin = BuscarUsuario(nombre);
            if(admin is Administrador) 
            {
                esAdmin = true;
            }
            else
            {
                throw new Exception("No es un administrador");
            }
            return esAdmin;
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
            foreach (Reserva reserva in prop.ListaReservas)
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

            stats.cGrafico.Width = 800;
            stats.cGrafico.Height = 600;

            // Crea una serie para el gráfico de sectores
            Series serieReservas = new Series();
            serieReservas.ChartType = SeriesChartType.Pie;

            // Agrega los puntos de datos a la serie
            serieReservas.Points.AddXY("CasaPorDia", reservasCasaDia);
            serieReservas.Points.AddXY("CasaFindeSemana", reservasCasaFinde);
            serieReservas.Points.AddXY("Habitaciones", reservasHabitaciones);

            // Cambia los colores específicos si es necesario
            serieReservas.Points[0].Color = Color.Red;
            serieReservas.Points[1].Color = Color.Green;
            serieReservas.Points[2].Color = Color.Blue;

            // Agrega la serie al gráfico
            stats.cGrafico.Series.Add(serieReservas);

            stats.ShowDialog();
        }
        #endregion
    }
}
