namespace TP2_Lab
{
    partial class FReservaImportada
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
            this.dGReservaImportada = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGReservaImportada)).BeginInit();
            this.SuspendLayout();
            // 
            // dGReservaImportada
            // 
            this.dGReservaImportada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGReservaImportada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGReservaImportada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGReservaImportada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.NumeroDeReserva,
            this.CheckIN,
            this.CheckOUT,
            this.Fecha,
            this.CantPersonas});
            this.dGReservaImportada.Location = new System.Drawing.Point(12, 12);
            this.dGReservaImportada.Name = "dGReservaImportada";
            this.dGReservaImportada.ReadOnly = true;
            this.dGReservaImportada.Size = new System.Drawing.Size(776, 397);
            this.dGReservaImportada.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // NumeroDeReserva
            // 
            this.NumeroDeReserva.HeaderText = "Numero de Reserva";
            this.NumeroDeReserva.Name = "NumeroDeReserva";
            this.NumeroDeReserva.ReadOnly = true;
            // 
            // CheckIN
            // 
            this.CheckIN.HeaderText = "Check In";
            this.CheckIN.Name = "CheckIN";
            this.CheckIN.ReadOnly = true;
            // 
            // CheckOUT
            // 
            this.CheckOUT.HeaderText = "Check Out";
            this.CheckOUT.Name = "CheckOUT";
            this.CheckOUT.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Realizado";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // CantPersonas
            // 
            this.CantPersonas.HeaderText = "Cantidad de Personas";
            this.CantPersonas.Name = "CantPersonas";
            this.CantPersonas.ReadOnly = true;
            // 
            // FReservaImportada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGReservaImportada);
            this.Name = "FReservaImportada";
            this.Text = "ReservaImportada";
            ((System.ComponentModel.ISupportInitialize)(this.dGReservaImportada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dGReservaImportada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPersonas;
    }
}