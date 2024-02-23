
namespace TP2_Lab
{
    partial class FRegistro
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
            this.tBuserN = new System.Windows.Forms.TextBox();
            this.tBcontraN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rBempleadoN = new System.Windows.Forms.RadioButton();
            this.rBadminN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBuserN
            // 
            this.tBuserN.Location = new System.Drawing.Point(174, 52);
            this.tBuserN.Name = "tBuserN";
            this.tBuserN.Size = new System.Drawing.Size(159, 22);
            this.tBuserN.TabIndex = 0;
            // 
            // tBcontraN
            // 
            this.tBcontraN.Location = new System.Drawing.Point(174, 113);
            this.tBcontraN.Name = "tBcontraN";
            this.tBcontraN.PasswordChar = '*';
            this.tBcontraN.Size = new System.Drawing.Size(159, 22);
            this.tBcontraN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(85, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(210, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rBempleadoN
            // 
            this.rBempleadoN.AutoSize = true;
            this.rBempleadoN.Location = new System.Drawing.Point(132, 32);
            this.rBempleadoN.Name = "rBempleadoN";
            this.rBempleadoN.Size = new System.Drawing.Size(92, 21);
            this.rBempleadoN.TabIndex = 6;
            this.rBempleadoN.TabStop = true;
            this.rBempleadoN.Text = "Empleado";
            this.rBempleadoN.UseVisualStyleBackColor = true;
            // 
            // rBadminN
            // 
            this.rBadminN.AutoSize = true;
            this.rBadminN.Location = new System.Drawing.Point(6, 32);
            this.rBadminN.Name = "rBadminN";
            this.rBadminN.Size = new System.Drawing.Size(116, 21);
            this.rBadminN.TabIndex = 7;
            this.rBadminN.TabStop = true;
            this.rBadminN.Text = "Administrador";
            this.rBadminN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBadminN);
            this.groupBox1.Controls.Add(this.rBempleadoN);
            this.groupBox1.Location = new System.Drawing.Point(78, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario:";
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBcontraN);
            this.Controls.Add(this.tBuserN);
            this.Name = "FRegistro";
            this.Text = "FRegistro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tBuserN;
        public System.Windows.Forms.TextBox tBcontraN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RadioButton rBempleadoN;
        public System.Windows.Forms.RadioButton rBadminN;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}