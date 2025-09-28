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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgregarPropiedad = new System.Windows.Forms.Button();
            this.btnEliminarPropiedad = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHabilitar = new System.Windows.Forms.CheckBox();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numCantHuespedes = new System.Windows.Forms.NumericUpDown();
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
            this.VerImagen = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnModificarPropiedad = new System.Windows.Forms.Button();
            this.DGReservas = new System.Windows.Forms.DataGridView();
            this.Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHuespedes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(550, 802);
            this.btnAgregarPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            this.btnAgregarPropiedad.Size = new System.Drawing.Size(112, 74);
            this.btnAgregarPropiedad.TabIndex = 0;
            this.btnAgregarPropiedad.Text = "Agregar Propiedad";
            this.btnAgregarPropiedad.UseVisualStyleBackColor = true;
            this.btnAgregarPropiedad.Click += new System.EventHandler(this.btnAgregarPropiedad_Click);
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(686, 802);
            this.btnEliminarPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(112, 75);
            this.btnEliminarPropiedad.TabIndex = 1;
            this.btnEliminarPropiedad.Text = "Eliminar Propiedad";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            this.btnEliminarPropiedad.Click += new System.EventHandler(this.btnEliminarPropiedad_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscar.Location = new System.Drawing.Point(70, 762);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 62);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Calendar
            // 
            this.Calendar.Enabled = false;
            this.Calendar.Location = new System.Drawing.Point(9, 212);
            this.Calendar.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.Calendar.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.Calendar.MaxSelectionCount = 10000;
            this.Calendar.MinDate = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 548);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de huespedes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHabilitar);
            this.groupBox1.Controls.Add(this.btnModificarReserva);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.numCantHuespedes);
            this.groupBox1.Controls.Add(this.cBLocalidad);
            this.groupBox1.Controls.Add(this.btnEliminarReserva);
            this.groupBox1.Controls.Add(this.btnReservar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.Calendar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(18, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(458, 902);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            // 
            // cbHabilitar
            // 
            this.cbHabilitar.AutoSize = true;
            this.cbHabilitar.Location = new System.Drawing.Point(9, 183);
            this.cbHabilitar.Name = "cbHabilitar";
            this.cbHabilitar.Size = new System.Drawing.Size(173, 24);
            this.cbHabilitar.TabIndex = 20;
            this.cbHabilitar.Text = "Habilitar Calendario";
            this.cbHabilitar.UseVisualStyleBackColor = true;
            this.cbHabilitar.CheckedChanged += new System.EventHandler(this.cbHabilitar_CheckedChanged);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModificarReserva.Location = new System.Drawing.Point(212, 763);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(112, 58);
            this.btnModificarReserva.TabIndex = 17;
            this.btnModificarReserva.Text = "Modificar Reserva";
            this.btnModificarReserva.UseVisualStyleBackColor = false;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(346, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(42, 38);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numCantHuespedes
            // 
            this.numCantHuespedes.Location = new System.Drawing.Point(212, 548);
            this.numCantHuespedes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantHuespedes.Name = "numCantHuespedes";
            this.numCantHuespedes.Size = new System.Drawing.Size(120, 26);
            this.numCantHuespedes.TabIndex = 18;
            this.numCantHuespedes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cBLocalidad
            // 
            this.cBLocalidad.FormattingEnabled = true;
            this.cBLocalidad.Location = new System.Drawing.Point(14, 88);
            this.cBLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBLocalidad.Name = "cBLocalidad";
            this.cBLocalidad.Size = new System.Drawing.Size(374, 28);
            this.cBLocalidad.TabIndex = 17;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.BackColor = System.Drawing.Color.Red;
            this.btnEliminarReserva.Location = new System.Drawing.Point(212, 831);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(112, 62);
            this.btnEliminarReserva.TabIndex = 16;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = false;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Lime;
            this.btnReservar.Location = new System.Drawing.Point(70, 831);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(112, 62);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de LLegada y Fecha de Salida:";
            // 
            // DGPropiedades
            // 
            this.DGPropiedades.AllowUserToAddRows = false;
            this.DGPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.VerImagen});
            this.DGPropiedades.Location = new System.Drawing.Point(500, 35);
            this.DGPropiedades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGPropiedades.MaximumSize = new System.Drawing.Size(1688, 692);
            this.DGPropiedades.Name = "DGPropiedades";
            this.DGPropiedades.ReadOnly = true;
            this.DGPropiedades.RowHeadersVisible = false;
            this.DGPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPropiedades.Size = new System.Drawing.Size(1688, 391);
            this.DGPropiedades.TabIndex = 15;
            this.DGPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPropiedades_CellClick);
            this.DGPropiedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPropiedades_CellContentClick);
            this.DGPropiedades.SelectionChanged += new System.EventHandler(this.DGPropiedades_SelectionChanged);
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
            this.Localidad.FillWeight = 25F;
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Direccion.FillWeight = 35F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // Nro
            // 
            this.Nro.FillWeight = 15F;
            this.Nro.HeaderText = "N°";
            this.Nro.MinimumWidth = 8;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // DiasPermitidos
            // 
            this.DiasPermitidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiasPermitidos.FillWeight = 47.9798F;
            this.DiasPermitidos.HeaderText = "Días Permitidos";
            this.DiasPermitidos.MinimumWidth = 8;
            this.DiasPermitidos.Name = "DiasPermitidos";
            this.DiasPermitidos.ReadOnly = true;
            this.DiasPermitidos.Width = 60;
            // 
            // PrecioBasico
            // 
            this.PrecioBasico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrecioBasico.FillWeight = 25F;
            this.PrecioBasico.HeaderText = "Precio Básico";
            this.PrecioBasico.MinimumWidth = 8;
            this.PrecioBasico.Name = "PrecioBasico";
            this.PrecioBasico.ReadOnly = true;
            this.PrecioBasico.Width = 130;
            // 
            // CantCamas
            // 
            this.CantCamas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantCamas.FillWeight = 25F;
            this.CantCamas.HeaderText = "Cantidad de Camas";
            this.CantCamas.MinimumWidth = 8;
            this.CantCamas.Name = "CantCamas";
            this.CantCamas.ReadOnly = true;
            this.CantCamas.Width = 125;
            // 
            // Estrellas
            // 
            this.Estrellas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Estrellas.FillWeight = 25F;
            this.Estrellas.HeaderText = "Estrellas";
            this.Estrellas.MinimumWidth = 8;
            this.Estrellas.Name = "Estrellas";
            this.Estrellas.ReadOnly = true;
            this.Estrellas.Width = 106;
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoHabitacion.FillWeight = 25F;
            this.TipoHabitacion.HeaderText = "Tipo de Habitación";
            this.TipoHabitacion.MinimumWidth = 8;
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.ReadOnly = true;
            this.TipoHabitacion.Width = 162;
            // 
            // Dueño
            // 
            this.Dueño.FillWeight = 35F;
            this.Dueño.HeaderText = "Propietario";
            this.Dueño.MinimumWidth = 8;
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            // 
            // VerImagen
            // 
            this.VerImagen.HeaderText = "Ver Imagen";
            this.VerImagen.MinimumWidth = 6;
            this.VerImagen.Name = "VerImagen";
            this.VerImagen.ReadOnly = true;
            this.VerImagen.UseColumnTextForButtonValue = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.exportarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // exportarDatosToolStripMenuItem
            // 
            this.exportarDatosToolStripMenuItem.Name = "exportarDatosToolStripMenuItem";
            this.exportarDatosToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.exportarDatosToolStripMenuItem.Text = "Exportar datos";
            this.exportarDatosToolStripMenuItem.Click += new System.EventHandler(this.exportarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.verAyudaToolStripMenuItem.Text = "Ver ayuda";
            this.verAyudaToolStripMenuItem.Click += new System.EventHandler(this.verAyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficosToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(48, 30);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectoresToolStripMenuItem,
            this.barraToolStripMenuItem});
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // sectoresToolStripMenuItem
            // 
            this.sectoresToolStripMenuItem.Name = "sectoresToolStripMenuItem";
            this.sectoresToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.sectoresToolStripMenuItem.Text = "Sectores";
            this.sectoresToolStripMenuItem.Click += new System.EventHandler(this.sectoresToolStripMenuItem_Click);
            // 
            // barraToolStripMenuItem
            // 
            this.barraToolStripMenuItem.Name = "barraToolStripMenuItem";
            this.barraToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.barraToolStripMenuItem.Text = "Barra";
            this.barraToolStripMenuItem.Click += new System.EventHandler(this.barraToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnModificarPropiedad
            // 
            this.btnModificarPropiedad.Location = new System.Drawing.Point(831, 802);
            this.btnModificarPropiedad.Name = "btnModificarPropiedad";
            this.btnModificarPropiedad.Size = new System.Drawing.Size(111, 75);
            this.btnModificarPropiedad.TabIndex = 18;
            this.btnModificarPropiedad.Text = "Modificar Propiedad";
            this.btnModificarPropiedad.UseVisualStyleBackColor = true;
            this.btnModificarPropiedad.Click += new System.EventHandler(this.btnModificarPropiedad_Click);
            // 
            // DGReservas
            // 
            this.DGReservas.AllowUserToAddRows = false;
            this.DGReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reserva,
            this.Cliente,
            this.NumReserva,
            this.Ingreso,
            this.Egreso,
            this.FechaReservacion,
            this.CantHuespedes});
            this.DGReservas.Location = new System.Drawing.Point(500, 451);
            this.DGReservas.Name = "DGReservas";
            this.DGReservas.ReadOnly = true;
            this.DGReservas.RowHeadersVisible = false;
            this.DGReservas.RowHeadersWidth = 51;
            this.DGReservas.RowTemplate.Height = 24;
            this.DGReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGReservas.Size = new System.Drawing.Size(1688, 342);
            this.DGReservas.TabIndex = 19;
            // 
            // Reserva
            // 
            this.Reserva.HeaderText = "Reserva";
            this.Reserva.MinimumWidth = 6;
            this.Reserva.Name = "Reserva";
            this.Reserva.ReadOnly = true;
            this.Reserva.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // NumReserva
            // 
            this.NumReserva.HeaderText = "Nro Reserva";
            this.NumReserva.MinimumWidth = 6;
            this.NumReserva.Name = "NumReserva";
            this.NumReserva.ReadOnly = true;
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.MinimumWidth = 6;
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Egreso";
            this.Egreso.MinimumWidth = 6;
            this.Egreso.Name = "Egreso";
            this.Egreso.ReadOnly = true;
            // 
            // FechaReservacion
            // 
            this.FechaReservacion.HeaderText = "Fecha Reservacion";
            this.FechaReservacion.MinimumWidth = 6;
            this.FechaReservacion.Name = "FechaReservacion";
            this.FechaReservacion.ReadOnly = true;
            // 
            // CantHuespedes
            // 
            this.CantHuespedes.HeaderText = "Cant. Huespedes";
            this.CantHuespedes.MinimumWidth = 6;
            this.CantHuespedes.Name = "CantHuespedes";
            this.CantHuespedes.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.DGReservas);
            this.Controls.Add(this.btnModificarPropiedad);
            this.Controls.Add(this.DGPropiedades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Reservas Tech";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.Button btnEliminarPropiedad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGPropiedades;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cBLocalidad;
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
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnModificarPropiedad;
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
        private System.Windows.Forms.DataGridViewButtonColumn VerImagen;
        private System.Windows.Forms.DataGridView DGReservas;
        private System.Windows.Forms.CheckBox cbHabilitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHuespedes;
    }
}