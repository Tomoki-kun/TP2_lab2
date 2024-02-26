
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
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGReservaImportada)).BeginInit();
            this.SuspendLayout();
            // 
            // dGReservaImportada
            // 
            this.dGReservaImportada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGReservaImportada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.NroReserva,
            this.FechaReservacion,
            this.FechaIn,
            this.FechaFin,
            this.Cantidad});
            this.dGReservaImportada.Location = new System.Drawing.Point(0, 0);
            this.dGReservaImportada.Name = "dGReservaImportada";
            this.dGReservaImportada.RowHeadersWidth = 51;
            this.dGReservaImportada.RowTemplate.Height = 24;
            this.dGReservaImportada.Size = new System.Drawing.Size(927, 438);
            this.dGReservaImportada.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // NroReserva
            // 
            this.NroReserva.HeaderText = "";
            this.NroReserva.MinimumWidth = 6;
            this.NroReserva.Name = "NroReserva";
            this.NroReserva.Width = 125;
            // 
            // FechaReservacion
            // 
            this.FechaReservacion.HeaderText = "";
            this.FechaReservacion.MinimumWidth = 6;
            this.FechaReservacion.Name = "FechaReservacion";
            this.FechaReservacion.Width = 125;
            // 
            // FechaIn
            // 
            this.FechaIn.HeaderText = "";
            this.FechaIn.MinimumWidth = 6;
            this.FechaIn.Name = "FechaIn";
            this.FechaIn.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // FReservaImportada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.dGReservaImportada);
            this.Name = "FReservaImportada";
            this.Text = "FReservaImportada";
            ((System.ComponentModel.ISupportInitialize)(this.dGReservaImportada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dGReservaImportada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}