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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPropiedad
            // 
            this.btnAgregarPropiedad.Location = new System.Drawing.Point(491, 735);
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
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(626, 735);
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
            this.btnBuscar.Location = new System.Drawing.Point(150, 578);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 62);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(1544, 732);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(112, 52);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1696, 735);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(112, 49);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(18, 188);
            this.Calendar.Margin = new System.Windows.Forms.Padding(14);
            this.Calendar.MaxDate = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
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
            this.label2.Location = new System.Drawing.Point(24, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de huespedes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(412, 791);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
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
            this.numCantHuespedes.Location = new System.Drawing.Point(216, 475);
            this.numCantHuespedes.Name = "numCantHuespedes";
            this.numCantHuespedes.Size = new System.Drawing.Size(120, 26);
            this.numCantHuespedes.TabIndex = 18;
            // 
            // cBTipoHabitaciones
            // 
            this.cBTipoHabitaciones.FormattingEnabled = true;
            this.cBTipoHabitaciones.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple"});
            this.cBTipoHabitaciones.Location = new System.Drawing.Point(216, 540);
            this.cBTipoHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBTipoHabitaciones.Name = "cBTipoHabitaciones";
            this.cBTipoHabitaciones.Size = new System.Drawing.Size(120, 28);
            this.cBTipoHabitaciones.TabIndex = 16;
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
            this.btnEliminarReserva.Location = new System.Drawing.Point(216, 704);
            this.btnEliminarReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(112, 62);
            this.btnEliminarReserva.TabIndex = 16;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(74, 704);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(112, 62);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
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
            this.DGPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGPropiedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.DGPropiedades.Location = new System.Drawing.Point(438, 30);
            this.DGPropiedades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGPropiedades.Name = "DGPropiedades";
            this.DGPropiedades.ReadOnly = true;
            this.DGPropiedades.RowHeadersVisible = false;
            this.DGPropiedades.RowHeadersWidth = 62;
            this.DGPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGPropiedades.Size = new System.Drawing.Size(1384, 692);
            this.DGPropiedades.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Objeto
            // 
            this.Objeto.HeaderText = "Objeto";
            this.Objeto.MinimumWidth = 8;
            this.Objeto.Name = "Objeto";
            this.Objeto.ReadOnly = true;
            this.Objeto.Visible = false;
            this.Objeto.Width = 62;
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 47.9798F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 75;
            // 
            // Localidad
            // 
            this.Localidad.FillWeight = 47.9798F;
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 113;
            // 
            // Direccion
            // 
            this.Direccion.FillWeight = 47.9798F;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 111;
            // 
            // Nro
            // 
            this.Nro.FillWeight = 47.9798F;
            this.Nro.HeaderText = "N°";
            this.Nro.MinimumWidth = 8;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 61;
            // 
            // DiasPermitidos
            // 
            this.DiasPermitidos.FillWeight = 47.9798F;
            this.DiasPermitidos.HeaderText = "Días Permitidos";
            this.DiasPermitidos.MinimumWidth = 8;
            this.DiasPermitidos.Name = "DiasPermitidos";
            this.DiasPermitidos.ReadOnly = true;
            this.DiasPermitidos.Width = 155;
            // 
            // PrecioBasico
            // 
            this.PrecioBasico.FillWeight = 47.9798F;
            this.PrecioBasico.HeaderText = "Precio Básico";
            this.PrecioBasico.MinimumWidth = 8;
            this.PrecioBasico.Name = "PrecioBasico";
            this.PrecioBasico.ReadOnly = true;
            this.PrecioBasico.Width = 141;
            // 
            // CantCamas
            // 
            this.CantCamas.FillWeight = 47.9798F;
            this.CantCamas.HeaderText = "Cantidad de Camas";
            this.CantCamas.MinimumWidth = 8;
            this.CantCamas.Name = "CantCamas";
            this.CantCamas.ReadOnly = true;
            this.CantCamas.Width = 125;
            // 
            // Estrellas
            // 
            this.Estrellas.FillWeight = 47.9798F;
            this.Estrellas.HeaderText = "Estrellas";
            this.Estrellas.MinimumWidth = 8;
            this.Estrellas.Name = "Estrellas";
            this.Estrellas.ReadOnly = true;
            this.Estrellas.Width = 106;
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.FillWeight = 47.9798F;
            this.TipoHabitacion.HeaderText = "Tipo de Habitación";
            this.TipoHabitacion.MinimumWidth = 8;
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.ReadOnly = true;
            this.TipoHabitacion.Width = 162;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Propietario";
            this.Dueño.MinimumWidth = 8;
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            this.Dueño.Width = 121;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imagen.FillWeight = 568.1818F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 50;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1832, 853);
            this.Controls.Add(this.DGPropiedades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnEliminarPropiedad);
            this.Controls.Add(this.btnAgregarPropiedad);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantHuespedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPropiedades)).EndInit();
            this.ResumeLayout(false);

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
    }
}

