﻿
namespace TP2_Lab
{
    partial class FPropiedad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPropiedad));
            this.rBcasaFinde = new System.Windows.Forms.RadioButton();
            this.rBcasaDia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxMascotas = new System.Windows.Forms.CheckBox();
            this.cbxDesayuno = new System.Windows.Forms.CheckBox();
            this.cbxLimpieza = new System.Windows.Forms.CheckBox();
            this.cbxWifi = new System.Windows.Forms.CheckBox();
            this.cbxPileta = new System.Windows.Forms.CheckBox();
            this.cbxCochera = new System.Windows.Forms.CheckBox();
            this.gbPropietario = new System.Windows.Forms.GroupBox();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPropiedad = new System.Windows.Forms.GroupBox();
            this.rBCasas = new System.Windows.Forms.RadioButton();
            this.rBHoteles = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numNro = new System.Windows.Forms.NumericUpDown();
            this.gBCasas = new System.Windows.Forms.GroupBox();
            this.gbCasaXDia = new System.Windows.Forms.GroupBox();
            this.numDiasPermitidos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tBlocalidad = new System.Windows.Forms.TextBox();
            this.gBHoteles = new System.Windows.Forms.GroupBox();
            this.cBTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numEstrellas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numCamas = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.FileImagen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.gbPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            this.gbPropiedad.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNro)).BeginInit();
            this.gBCasas.SuspendLayout();
            this.gbCasaXDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasPermitidos)).BeginInit();
            this.gBHoteles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // rBcasaFinde
            // 
            this.rBcasaFinde.AutoSize = true;
            this.rBcasaFinde.Location = new System.Drawing.Point(122, 22);
            this.rBcasaFinde.Name = "rBcasaFinde";
            this.rBcasaFinde.Size = new System.Drawing.Size(136, 17);
            this.rBcasaFinde.TabIndex = 15;
            this.rBcasaFinde.Text = "Casa de Fin de semana";
            this.rBcasaFinde.UseVisualStyleBackColor = true;
            // 
            // rBcasaDia
            // 
            this.rBcasaDia.AutoSize = true;
            this.rBcasaDia.Checked = true;
            this.rBcasaDia.Location = new System.Drawing.Point(11, 23);
            this.rBcasaDia.Name = "rBcasaDia";
            this.rBcasaDia.Size = new System.Drawing.Size(86, 17);
            this.rBcasaDia.TabIndex = 14;
            this.rBcasaDia.TabStop = true;
            this.rBcasaDia.Text = "Casa por Dia";
            this.rBcasaDia.UseVisualStyleBackColor = true;
            this.rBcasaDia.CheckedChanged += new System.EventHandler(this.rBcasaDia_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMascotas);
            this.groupBox2.Controls.Add(this.cbxDesayuno);
            this.groupBox2.Controls.Add(this.cbxLimpieza);
            this.groupBox2.Controls.Add(this.cbxWifi);
            this.groupBox2.Controls.Add(this.cbxPileta);
            this.groupBox2.Controls.Add(this.cbxCochera);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios:";
            // 
            // cbxMascotas
            // 
            this.cbxMascotas.AutoSize = true;
            this.cbxMascotas.Location = new System.Drawing.Point(43, 137);
            this.cbxMascotas.Name = "cbxMascotas";
            this.cbxMascotas.Size = new System.Drawing.Size(140, 17);
            this.cbxMascotas.TabIndex = 8;
            this.cbxMascotas.Text = "Posibilidad de Mascotas";
            this.cbxMascotas.UseVisualStyleBackColor = true;
            // 
            // cbxDesayuno
            // 
            this.cbxDesayuno.AutoSize = true;
            this.cbxDesayuno.Location = new System.Drawing.Point(43, 114);
            this.cbxDesayuno.Name = "cbxDesayuno";
            this.cbxDesayuno.Size = new System.Drawing.Size(74, 17);
            this.cbxDesayuno.TabIndex = 7;
            this.cbxDesayuno.Text = "Desayuno";
            this.cbxDesayuno.UseVisualStyleBackColor = true;
            // 
            // cbxLimpieza
            // 
            this.cbxLimpieza.AutoSize = true;
            this.cbxLimpieza.Location = new System.Drawing.Point(43, 91);
            this.cbxLimpieza.Name = "cbxLimpieza";
            this.cbxLimpieza.Size = new System.Drawing.Size(108, 17);
            this.cbxLimpieza.TabIndex = 6;
            this.cbxLimpieza.Text = "Servicio Limpieza";
            this.cbxLimpieza.UseVisualStyleBackColor = true;
            // 
            // cbxWifi
            // 
            this.cbxWifi.AutoSize = true;
            this.cbxWifi.Location = new System.Drawing.Point(43, 68);
            this.cbxWifi.Name = "cbxWifi";
            this.cbxWifi.Size = new System.Drawing.Size(44, 17);
            this.cbxWifi.TabIndex = 5;
            this.cbxWifi.Text = "Wifi";
            this.cbxWifi.UseVisualStyleBackColor = true;
            // 
            // cbxPileta
            // 
            this.cbxPileta.AutoSize = true;
            this.cbxPileta.Location = new System.Drawing.Point(43, 45);
            this.cbxPileta.Name = "cbxPileta";
            this.cbxPileta.Size = new System.Drawing.Size(52, 17);
            this.cbxPileta.TabIndex = 4;
            this.cbxPileta.Text = "Pileta";
            this.cbxPileta.UseVisualStyleBackColor = true;
            // 
            // cbxCochera
            // 
            this.cbxCochera.AutoSize = true;
            this.cbxCochera.Location = new System.Drawing.Point(43, 19);
            this.cbxCochera.Name = "cbxCochera";
            this.cbxCochera.Size = new System.Drawing.Size(66, 17);
            this.cbxCochera.TabIndex = 3;
            this.cbxCochera.Text = "Cochera";
            this.cbxCochera.UseVisualStyleBackColor = true;
            // 
            // gbPropietario
            // 
            this.gbPropietario.Controls.Add(this.numDNI);
            this.gbPropietario.Controls.Add(this.tBApellido);
            this.gbPropietario.Controls.Add(this.tBnombre);
            this.gbPropietario.Controls.Add(this.label3);
            this.gbPropietario.Controls.Add(this.label2);
            this.gbPropietario.Controls.Add(this.label1);
            this.gbPropietario.Location = new System.Drawing.Point(289, 19);
            this.gbPropietario.Name = "gbPropietario";
            this.gbPropietario.Size = new System.Drawing.Size(276, 130);
            this.gbPropietario.TabIndex = 2;
            this.gbPropietario.TabStop = false;
            this.gbPropietario.Text = "Datos Propietario:";
            // 
            // numDNI
            // 
            this.numDNI.Location = new System.Drawing.Point(106, 79);
            this.numDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDNI.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(100, 20);
            this.numDNI.TabIndex = 18;
            this.numDNI.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // tBApellido
            // 
            this.tBApellido.Location = new System.Drawing.Point(106, 55);
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(100, 20);
            this.tBApellido.TabIndex = 17;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(106, 32);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(213, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad de camas:";
            // 
            // tBdireccion
            // 
            this.tBdireccion.Location = new System.Drawing.Point(154, 63);
            this.tBdireccion.Name = "tBdireccion";
            this.tBdireccion.Size = new System.Drawing.Size(100, 20);
            this.tBdireccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dias Permitidos:";
            // 
            // gbPropiedad
            // 
            this.gbPropiedad.Controls.Add(this.rBCasas);
            this.gbPropiedad.Controls.Add(this.rBHoteles);
            this.gbPropiedad.Location = new System.Drawing.Point(12, 3);
            this.gbPropiedad.Name = "gbPropiedad";
            this.gbPropiedad.Size = new System.Drawing.Size(169, 42);
            this.gbPropiedad.TabIndex = 11;
            this.gbPropiedad.TabStop = false;
            this.gbPropiedad.Text = "Propiedad";
            // 
            // rBCasas
            // 
            this.rBCasas.AutoSize = true;
            this.rBCasas.Checked = true;
            this.rBCasas.Location = new System.Drawing.Point(6, 19);
            this.rBCasas.Name = "rBCasas";
            this.rBCasas.Size = new System.Drawing.Size(54, 17);
            this.rBCasas.TabIndex = 1;
            this.rBCasas.TabStop = true;
            this.rBCasas.Text = "Casas";
            this.rBCasas.UseVisualStyleBackColor = true;
            this.rBCasas.CheckedChanged += new System.EventHandler(this.rBCasas_CheckedChanged);
            // 
            // rBHoteles
            // 
            this.rBHoteles.AutoSize = true;
            this.rBHoteles.Location = new System.Drawing.Point(97, 19);
            this.rBHoteles.Name = "rBHoteles";
            this.rBHoteles.Size = new System.Drawing.Size(61, 17);
            this.rBHoteles.TabIndex = 2;
            this.rBHoteles.Text = "Hoteles";
            this.rBHoteles.UseVisualStyleBackColor = true;
            this.rBHoteles.CheckedChanged += new System.EventHandler(this.rBHoteles_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.btnImagen);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numNro);
            this.groupBox5.Controls.Add(this.gBCasas);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tBlocalidad);
            this.groupBox5.Controls.Add(this.gBHoteles);
            this.groupBox5.Controls.Add(this.numCamas);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tBdireccion);
            this.groupBox5.Location = new System.Drawing.Point(300, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 396);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Propiedad";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(242, 177);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(89, 27);
            this.btnImagen.TabIndex = 21;
            this.btnImagen.Text = "Cargar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Localidad:";
            // 
            // numNro
            // 
            this.numNro.Location = new System.Drawing.Point(153, 98);
            this.numNro.Name = "numNro";
            this.numNro.Size = new System.Drawing.Size(100, 20);
            this.numNro.TabIndex = 13;
            // 
            // gBCasas
            // 
            this.gBCasas.Controls.Add(this.gbCasaXDia);
            this.gBCasas.Controls.Add(this.rBcasaFinde);
            this.gBCasas.Controls.Add(this.rBcasaDia);
            this.gBCasas.Controls.Add(this.gbPropietario);
            this.gBCasas.Location = new System.Drawing.Point(5, 222);
            this.gBCasas.Name = "gBCasas";
            this.gBCasas.Size = new System.Drawing.Size(571, 155);
            this.gBCasas.TabIndex = 0;
            this.gBCasas.TabStop = false;
            // 
            // gbCasaXDia
            // 
            this.gbCasaXDia.Controls.Add(this.numDiasPermitidos);
            this.gbCasaXDia.Controls.Add(this.label6);
            this.gbCasaXDia.Location = new System.Drawing.Point(11, 46);
            this.gbCasaXDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCasaXDia.Name = "gbCasaXDia";
            this.gbCasaXDia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCasaXDia.Size = new System.Drawing.Size(219, 49);
            this.gbCasaXDia.TabIndex = 16;
            this.gbCasaXDia.TabStop = false;
            // 
            // numDiasPermitidos
            // 
            this.numDiasPermitidos.Location = new System.Drawing.Point(103, 25);
            this.numDiasPermitidos.Name = "numDiasPermitidos";
            this.numDiasPermitidos.Size = new System.Drawing.Size(100, 20);
            this.numDiasPermitidos.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "N°";
            // 
            // tBlocalidad
            // 
            this.tBlocalidad.Location = new System.Drawing.Point(153, 34);
            this.tBlocalidad.Name = "tBlocalidad";
            this.tBlocalidad.Size = new System.Drawing.Size(100, 20);
            this.tBlocalidad.TabIndex = 10;
            // 
            // gBHoteles
            // 
            this.gBHoteles.Controls.Add(this.cBTipoHabitacion);
            this.gBHoteles.Controls.Add(this.label9);
            this.gBHoteles.Controls.Add(this.numEstrellas);
            this.gBHoteles.Controls.Add(this.label8);
            this.gBHoteles.Location = new System.Drawing.Point(297, 19);
            this.gBHoteles.Name = "gBHoteles";
            this.gBHoteles.Size = new System.Drawing.Size(282, 113);
            this.gBHoteles.TabIndex = 20;
            this.gBHoteles.TabStop = false;
            this.gBHoteles.Visible = false;
            // 
            // cBTipoHabitacion
            // 
            this.cBTipoHabitacion.FormattingEnabled = true;
            this.cBTipoHabitacion.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Triple"});
            this.cBTipoHabitacion.Location = new System.Drawing.Point(145, 81);
            this.cBTipoHabitacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBTipoHabitacion.Name = "cBTipoHabitacion";
            this.cBTipoHabitacion.Size = new System.Drawing.Size(101, 21);
            this.cBTipoHabitacion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tipo de habitacion";
            // 
            // numEstrellas
            // 
            this.numEstrellas.Location = new System.Drawing.Point(145, 49);
            this.numEstrellas.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numEstrellas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEstrellas.Name = "numEstrellas";
            this.numEstrellas.Size = new System.Drawing.Size(100, 20);
            this.numEstrellas.TabIndex = 14;
            this.numEstrellas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estrellas";
            // 
            // numCamas
            // 
            this.numCamas.Location = new System.Drawing.Point(153, 125);
            this.numCamas.Name = "numCamas";
            this.numCamas.Size = new System.Drawing.Size(100, 20);
            this.numCamas.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Precio";
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(61, 249);
            this.numPrecio.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(109, 20);
            this.numPrecio.TabIndex = 9;
            // 
            // FileImagen
            // 
            this.FileImagen.FileName = "openFileDialog1";
            // 
            // FPropiedad
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 384);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbPropiedad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPropiedad";
            this.Text = "FPropiedad";
            this.Load += new System.EventHandler(this.FPropiedad_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPropietario.ResumeLayout(false);
            this.gbPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            this.gbPropiedad.ResumeLayout(false);
            this.gbPropiedad.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNro)).EndInit();
            this.gBCasas.ResumeLayout(false);
            this.gBCasas.PerformLayout();
            this.gbCasaXDia.ResumeLayout(false);
            this.gbCasaXDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasPermitidos)).EndInit();
            this.gBHoteles.ResumeLayout(false);
            this.gBHoteles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton rBcasaFinde;
        public System.Windows.Forms.RadioButton rBcasaDia;
        public System.Windows.Forms.CheckBox cbxMascotas;
        public System.Windows.Forms.CheckBox cbxDesayuno;
        public System.Windows.Forms.CheckBox cbxLimpieza;
        public System.Windows.Forms.CheckBox cbxWifi;
        public System.Windows.Forms.CheckBox cbxPileta;
        public System.Windows.Forms.CheckBox cbxCochera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tBApellido;
        public System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tBdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gBHoteles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gBCasas;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tBlocalidad;
        public System.Windows.Forms.NumericUpDown numCamas;
        public System.Windows.Forms.NumericUpDown numEstrellas;
        public System.Windows.Forms.RadioButton rBCasas;
        public System.Windows.Forms.RadioButton rBHoteles;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.NumericUpDown numDiasPermitidos;
        public System.Windows.Forms.NumericUpDown numNro;
        public System.Windows.Forms.NumericUpDown numDNI;
        public System.Windows.Forms.NumericUpDown numPrecio;
        public System.Windows.Forms.ComboBox cBTipoHabitacion;
        private System.Windows.Forms.OpenFileDialog FileImagen;
        public System.Windows.Forms.Button btnImagen;
        public System.Windows.Forms.GroupBox gbPropiedad;
        public System.Windows.Forms.GroupBox gbCasaXDia;
        public System.Windows.Forms.GroupBox gbPropietario;
    }
}