
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbContra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rBempleadoN = new System.Windows.Forms.RadioButton();
            this.rBadminN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBuserN
            // 
            this.tBuserN.Location = new System.Drawing.Point(183, 51);
            this.tBuserN.Name = "tBuserN";
            this.tBuserN.Size = new System.Drawing.Size(159, 22);
            this.tBuserN.TabIndex = 0;
            // 
            // tBcontraN
            // 
            this.tBcontraN.Location = new System.Drawing.Point(183, 112);
            this.tBcontraN.Name = "tBcontraN";
            this.tBcontraN.PasswordChar = '*';
            this.tBcontraN.Size = new System.Drawing.Size(159, 22);
            this.tBcontraN.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(47, 56);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(115, 17);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Nombre Usuario:";
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Location = new System.Drawing.Point(47, 112);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(85, 17);
            this.lbContra.TabIndex = 3;
            this.lbContra.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(94, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(219, 236);
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
            this.rBadminN.Checked = true;
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
            this.groupBox1.Location = new System.Drawing.Point(87, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.lbUser);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tBuserN);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tBcontraN);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lbContra);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 295);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(424, 316);
            this.Controls.Add(this.groupBox2);
            this.Name = "FRegistro";
            this.Text = "FRegistro";
            this.Load += new System.EventHandler(this.FRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tBuserN;
        public System.Windows.Forms.TextBox tBcontraN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RadioButton rBempleadoN;
        public System.Windows.Forms.RadioButton rBadminN;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbUser;
        public System.Windows.Forms.Label lbContra;
    }
}