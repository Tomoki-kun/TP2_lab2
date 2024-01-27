namespace TP2_Lab
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.btnEliminarPropiedad = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rBcasa = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numCantHuespedes = new System.Windows.Forms.NumericUpDown();
            this.cBTipoHabitaciones = new System.Windows.Forms.ComboBox();
            this.cBLocalidad = new System.Windows.Forms.ComboBox();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGPropiedades = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasPermitidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBasico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCamas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imagen2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(489, 641);
            this.btnAgregarPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(100, 59);
            this.btnAgregarPropiedad.TabIndex = 0;
            this.btnAgregarPropiedad.Text = "Agregar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(609, 641);
            this.btnEliminarPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(100, 60);
            this.btnEliminarPropiedad.TabIndex = 1;
            this.btnEliminarPropiedad.Text = "Eliminar Propiedad";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(134, 607);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 49);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(1425, 639);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(100, 42);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1561, 641);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 39);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(8, 170);
            this.Calendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Calendar.MaxDate = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de huespedes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Habitaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rBcasa);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.numCantHuespedes);
            this.groupBox1.Controls.Add(this.cBTipoHabitaciones);
            this.groupBox1.Controls.Add(this.cBLocalidad);
            this.groupBox1.Controls.Add(this.btnEliminarReserva);
            this.groupBox1.Controls.Add(this.btnReservar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Calendar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 721);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tipo Casa:";
            // 
            // rBcasa
            // 
            this.rBcasa.AutoSize = true;
            this.rBcasa.Location = new System.Drawing.Point(189, 556);
            this.rBcasa.Name = "rBcasa";
            this.rBcasa.Size = new System.Drawing.Size(61, 21);
            this.rBcasa.TabIndex = 21;
            this.rBcasa.TabStop = true;
            this.rBcasa.Text = "Casa";
            this.rBcasa.UseVisualStyleBackColor = true;
            this.rBcasa.CheckedChanged += new System.EventHandler(this.rBcasa_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(308, 33);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(37, 31);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numCantHuespedes
            // 
            this.numCantHuespedes.Location = new System.Drawing.Point(188, 438);
            this.numCantHuespedes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCantHuespedes.Name = "numCantHuespedes";
            this.numCantHuespedes.Size = new System.Drawing.Size(107, 22);
            this.numCantHuespedes.TabIndex = 18;
            // 
            // cBTipoHabitaciones
            // 
            this.cBTipoHabitaciones.FormattingEnabled = true;
            this.cBTipoHabitaciones.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple"});
            this.cBTipoHabitaciones.Location = new System.Drawing.Point(188, 490);
            this.cBTipoHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.cBTipoHabitaciones.Name = "cBTipoHabitaciones";
            this.cBTipoHabitaciones.Size = new System.Drawing.Size(107, 24);
            this.cBTipoHabitaciones.TabIndex = 16;
            this.cBTipoHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cBTipoHabitaciones_SelectedIndexChanged);
            // 
            // cBLocalidad
            // 
            this.cBLocalidad.FormattingEnabled = true;
            this.cBLocalidad.Location = new System.Drawing.Point(12, 70);
            this.cBLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cBLocalidad.Name = "cBLocalidad";
            this.cBLocalidad.Size = new System.Drawing.Size(333, 24);
            this.cBLocalidad.TabIndex = 17;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(188, 664);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(100, 49);
            this.btnEliminarReserva.TabIndex = 16;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(63, 664);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 49);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de LLegada y Fecha de Salida:";
            // 
            // DGPropiedades
            // 
            this.DGPropiedades.AllowUserToAddRows = false;
            this.DGPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGPropiedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGPropiedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGPropiedades.ColumnHeadersHeight = 50;
            this.DGPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Objeto,
            this.Tipo,
            this.Localidad,
            this.Direccion,
            this.Nro,
            this.DiasPermitidos,
            this.PrecioBasico,
            this.CantCamas,
            this.Estrellas,
            this.TipoHabitacion,
            this.Dueño,
            this.Imagen,
            this.Imagen2});
            this.DGPropiedades.Location = new System.Drawing.Point(444, 28);
            this.DGPropiedades.Margin = new System.Windows.Forms.Padding(4);
            this.DGPropiedades.MaximumSize = new System.Drawing.Size(1231, 554);
            this.DGPropiedades.Name = "DGPropiedades";
            this.DGPropiedades.ReadOnly = true;
            this.DGPropiedades.RowHeadersVisible = false;
            this.DGPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPropiedades.Size = new System.Drawing.Size(1231, 554);
            this.DGPropiedades.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1704, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.exportarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // exportarDatosToolStripMenuItem
            // 
            this.exportarDatosToolStripMenuItem.Name = "exportarDatosToolStripMenuItem";
            this.exportarDatosToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exportarDatosToolStripMenuItem.Text = "Exportar datos";
            this.exportarDatosToolStripMenuItem.Click += new System.EventHandler(this.exportarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.verAyudaToolStripMenuItem.Text = "Ver ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectoresToolStripMenuItem,
            this.barraToolStripMenuItem});
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // sectoresToolStripMenuItem
            // 
            this.sectoresToolStripMenuItem.Name = "sectoresToolStripMenuItem";
            this.sectoresToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.sectoresToolStripMenuItem.Text = "Sectores";
            this.sectoresToolStripMenuItem.Click += new System.EventHandler(this.sectoresToolStripMenuItem_Click);
            // 
            // barraToolStripMenuItem
            // 
            this.barraToolStripMenuItem.Name = "barraToolStripMenuItem";
            this.barraToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.barraToolStripMenuItem.Text = "Barra";
            this.barraToolStripMenuItem.Click += new System.EventHandler(this.barraToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Objeto
            // 
            this.Objeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Objeto.FillWeight = 2F;
            this.Objeto.HeaderText = "Objeto";
            this.Objeto.MinimumWidth = 8;
            this.Objeto.Name = "Objeto";
            this.Objeto.ReadOnly = true;
            this.Objeto.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tipo.FillWeight = 48F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 78;
            // 
            // Localidad
            // 
            this.Localidad.FillWeight = 47.9798F;
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 98;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Direccion.FillWeight = 47.9798F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // Nro
            // 
            this.Nro.FillWeight = 47.9798F;
            this.Nro.HeaderText = "N°";
            this.Nro.MinimumWidth = 8;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 53;
            // 
            // DiasPermitidos
            // 
            this.DiasPermitidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiasPermitidos.FillWeight = 47.9798F;
            this.DiasPermitidos.HeaderText = "Días Permitidos";
            this.DiasPermitidos.MinimumWidth = 8;
            this.DiasPermitidos.Name = "DiasPermitidos";
            this.DiasPermitidos.ReadOnly = true;
            this.DiasPermitidos.Width = 44;
            // 
            // PrecioBasico
            // 
            this.PrecioBasico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioBasico.FillWeight = 47.9798F;
            this.PrecioBasico.HeaderText = "Precio Básico";
            this.PrecioBasico.MinimumWidth = 8;
            this.PrecioBasico.Name = "PrecioBasico";
            this.PrecioBasico.ReadOnly = true;
            this.PrecioBasico.Width = 50;
            // 
            // CantCamas
            // 
            this.CantCamas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantCamas.FillWeight = 47.9798F;
            this.CantCamas.HeaderText = "Cantidad de Camas";
            this.CantCamas.MinimumWidth = 8;
            this.CantCamas.Name = "CantCamas";
            this.CantCamas.ReadOnly = true;
            this.CantCamas.Width = 40;
            // 
            // Estrellas
            // 
            this.Estrellas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estrellas.FillWeight = 47.9798F;
            this.Estrellas.HeaderText = "Estrellas";
            this.Estrellas.MinimumWidth = 8;
            this.Estrellas.Name = "Estrellas";
            this.Estrellas.ReadOnly = true;
            this.Estrellas.Width = 35;
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoHabitacion.FillWeight = 47.9798F;
            this.TipoHabitacion.HeaderText = "Tipo de Habitación";
            this.TipoHabitacion.MinimumWidth = 8;
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.ReadOnly = true;
            this.TipoHabitacion.Width = 60;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Propietario";
            this.Dueño.MinimumWidth = 8;
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            this.Dueño.Width = 106;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen.FillWeight = 568.2F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.MinimumWidth = 2;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Width = 332;
            // 
            // Imagen2
            // 
            this.Imagen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen2.FillWeight = 568.2F;
            this.Imagen2.HeaderText = "Imagen2";
            this.Imagen2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen2.MinimumWidth = 2;
            this.Imagen2.Name = "Imagen2";
            this.Imagen2.ReadOnly = true;
            this.Imagen2.Width = 332;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1704, 772);
            this.Controls.Add(this.DGPropiedades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.Button btnEliminarPropiedad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGPropiedades;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cBLocalidad;
        private System.Windows.Forms.ComboBox cBTipoHabitaciones;
        private System.Windows.Forms.NumericUpDown numCantHuespedes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        public System.Windows.Forms.RadioButton rBcasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasPermitidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBasico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCamas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewImageColumn Imagen2;
    }
}

