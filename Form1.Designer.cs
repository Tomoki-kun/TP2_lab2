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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numCantHuespedes = new System.Windows.Forms.NumericUpDown();
            this.cBTipoHabitaciones = new System.Windows.Forms.ComboBox();
            this.cBLocalidad = new System.Windows.Forms.ComboBox();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGPropiedades = new System.Windows.Forms.DataGridView();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(367, 521);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(75, 48);
            this.btnAgregarPropiedad.TabIndex = 0;
            this.btnAgregarPropiedad.Text = "Agregar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(457, 521);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(75, 49);
            this.btnEliminarPropiedad.TabIndex = 1;
            this.btnEliminarPropiedad.Text = "Eliminar Propiedad";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(97, 423);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(1069, 519);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 34);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1171, 521);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 32);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(6, 138);
            this.Calendar.MaxDate = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de huespedes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Habitaciones:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 550);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(231, 27);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(28, 25);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numCantHuespedes
            // 
            this.numCantHuespedes.Location = new System.Drawing.Point(141, 356);
            this.numCantHuespedes.Margin = new System.Windows.Forms.Padding(2);
            this.numCantHuespedes.Name = "numCantHuespedes";
            this.numCantHuespedes.Size = new System.Drawing.Size(80, 20);
            this.numCantHuespedes.TabIndex = 18;
            // 
            // cBTipoHabitaciones
            // 
            this.cBTipoHabitaciones.FormattingEnabled = true;
            this.cBTipoHabitaciones.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple"});
            this.cBTipoHabitaciones.Location = new System.Drawing.Point(141, 398);
            this.cBTipoHabitaciones.Name = "cBTipoHabitaciones";
            this.cBTipoHabitaciones.Size = new System.Drawing.Size(81, 21);
            this.cBTipoHabitaciones.TabIndex = 16;
            // 
            // cBLocalidad
            // 
            this.cBLocalidad.FormattingEnabled = true;
            this.cBLocalidad.Location = new System.Drawing.Point(9, 57);
            this.cBLocalidad.Name = "cBLocalidad";
            this.cBLocalidad.Size = new System.Drawing.Size(251, 21);
            this.cBLocalidad.TabIndex = 17;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(141, 505);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarReserva.TabIndex = 16;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(46, 505);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 40);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 15);
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
            this.Imagen});
            this.DGPropiedades.Location = new System.Drawing.Point(333, 23);
            this.DGPropiedades.MaximumSize = new System.Drawing.Size(923, 450);
            this.DGPropiedades.Name = "DGPropiedades";
            this.DGPropiedades.ReadOnly = true;
            this.DGPropiedades.RowHeadersVisible = false;
            this.DGPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPropiedades.Size = new System.Drawing.Size(923, 450);
            this.DGPropiedades.TabIndex = 15;
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
            this.Localidad.Width = 90;
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
            this.Nro.Width = 50;
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
            this.Dueño.Width = 96;
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
            this.menuStrip1.Size = new System.Drawing.Size(1278, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
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
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // exportarDatosToolStripMenuItem
            // 
            this.exportarDatosToolStripMenuItem.Name = "exportarDatosToolStripMenuItem";
            this.exportarDatosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportarDatosToolStripMenuItem.Text = "Exportar datos";
            this.exportarDatosToolStripMenuItem.Click += new System.EventHandler(this.exportarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verAyudaToolStripMenuItem.Text = "Ver ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
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
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectoresToolStripMenuItem,
            this.barraToolStripMenuItem});
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // sectoresToolStripMenuItem
            // 
            this.sectoresToolStripMenuItem.Name = "sectoresToolStripMenuItem";
            this.sectoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sectoresToolStripMenuItem.Text = "Sectores";
            this.sectoresToolStripMenuItem.Click += new System.EventHandler(this.sectoresToolStripMenuItem_Click);
            // 
            // barraToolStripMenuItem
            // 
            this.barraToolStripMenuItem.Name = "barraToolStripMenuItem";
            this.barraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.barraToolStripMenuItem.Text = "Barra";
            this.barraToolStripMenuItem.Click += new System.EventHandler(this.barraToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 627);
            this.Controls.Add(this.DGPropiedades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
    }
}

