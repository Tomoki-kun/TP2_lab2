
namespace TP2_Lab
{
    partial class FCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tBnombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.dTfechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(44, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(256, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tBnombreC
            // 
            this.tBnombreC.Location = new System.Drawing.Point(161, 62);
            this.tBnombreC.Margin = new System.Windows.Forms.Padding(4);
            this.tBnombreC.Name = "tBnombreC";
            this.tBnombreC.Size = new System.Drawing.Size(195, 22);
            this.tBnombreC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI:";
            // 
            // numDNI
            // 
            this.numDNI.Location = new System.Drawing.Point(162, 96);
            this.numDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDNI.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(194, 22);
            this.numDNI.TabIndex = 8;
            this.numDNI.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // dTfechaNac
            // 
            this.dTfechaNac.Location = new System.Drawing.Point(161, 137);
            this.dTfechaNac.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dTfechaNac.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.dTfechaNac.Name = "dTfechaNac";
            this.dTfechaNac.Size = new System.Drawing.Size(195, 22);
            this.dTfechaNac.TabIndex = 10;
            this.dTfechaNac.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTfechaNac);
            this.Controls.Add(this.numDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBnombreC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCliente";
            this.Text = "FCliente";
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tBnombreC;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numDNI;
        public System.Windows.Forms.DateTimePicker dTfechaNac;
        private System.Windows.Forms.Label label4;
    }
}