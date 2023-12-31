﻿using System;
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
        private int cantPropiedades = 0,
            cantReservas = 0,
            reservasCasaDia = 0,
            reservasCasaFinde = 0,
            reservasHabitaciones = 0;
        private List<IExportable> listaDatos = new List<IExportable>();
        private List<Usuario> listaUsuarios = new List<Usuario>();
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
            listaUsuarios.Add(usuario);
            listaUsuarios.Sort();
            int pos = listaUsuarios.BinarySearch(usuario);
            while ( pos < 0 || (pos>=0 && ((usuario is Administrador  && listaUsuarios[pos] is Empleado) || (usuario is Empleado && listaUsuarios[pos] is Administrador))))
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
                                 || prop is Casa && !(prop is CasaFindeSemana) && numeroDias >= ((Casa)prop).DiasPermitidos || prop is Habitaciones)
                            {
                                Reserva miReserva = new Reserva(miCliente, cantReservas, huespedes, inicio, fin);
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

        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDatos(listaDatos, miArchivo);
            MessageBox.Show("Datos exportados correctamente", "Operacion exitosa");
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
            string rutaCompleta = Path.Combine(Application.StartupPath,"Resource", rutaPaginaHTML);

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

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            bitmap = new Bitmap(propiedad.Imagen, 50, 25);
            fila.Cells[11].Value = bitmap;


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

        private void RefreshDataGridView()
        {
            DGPropiedades.Rows.Clear();
            foreach(Propiedad propi in nuevoS.ListaPropiedad)
            {
                DGAgregarPropiedad(propi);
            }
        }
        #endregion

        #region Ventana de Graficos
        private void barraToolStripMenuItem_Click(object sender, EventArgs e)
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

            // Mostrar el formulario con el gráfico
            stats2.ShowDialog();
        }

        private void sectoresToolStripMenuItem_Click(object sender, EventArgs e)
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
