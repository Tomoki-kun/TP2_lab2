
namespace TP2_Lab
{
    partial class FLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBusuario = new System.Windows.Forms.TextBox();
            this.tBpasword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBadministrador = new System.Windows.Forms.RadioButton();
            this.rBempleado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // tBusuario
            // 
            this.tBusuario.Location = new System.Drawing.Point(99, 70);
            this.tBusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBusuario.Name = "tBusuario";
            this.tBusuario.Size = new System.Drawing.Size(487, 22);
            this.tBusuario.TabIndex = 2;
            // 
            // tBpasword
            // 
            this.tBpasword.Location = new System.Drawing.Point(99, 170);
            this.tBpasword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBpasword.Name = "tBpasword";
            this.tBpasword.PasswordChar = '*';
            this.tBpasword.Size = new System.Drawing.Size(487, 22);
            this.tBpasword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBempleado);
            this.groupBox1.Controls.Add(this.rBadministrador);
            this.groupBox1.Location = new System.Drawing.Point(245, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango:";
            // 
            // rBadministrador
            // 
            this.rBadministrador.AutoSize = true;
            this.rBadministrador.Checked = true;
            this.rBadministrador.Location = new System.Drawing.Point(3, 18);
            this.rBadministrador.Name = "rBadministrador";
            this.rBadministrador.Size = new System.Drawing.Size(116, 21);
            this.rBadministrador.TabIndex = 0;
            this.rBadministrador.TabStop = true;
            this.rBadministrador.Text = "Administrador";
            this.rBadministrador.UseVisualStyleBackColor = true;
            // 
            // rBempleado
            // 
            this.rBempleado.AutoSize = true;
            this.rBempleado.Location = new System.Drawing.Point(125, 21);
            this.rBempleado.Name = "rBempleado";
            this.rBempleado.Size = new System.Drawing.Size(92, 21);
            this.rBempleado.TabIndex = 1;
            this.rBempleado.Text = "Empleado";
            this.rBempleado.UseVisualStyleBackColor = true;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBpasword);
            this.Controls.Add(this.tBusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FLogin";
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tBusuario;
        public System.Windows.Forms.TextBox tBpasword;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rBempleado;
        public System.Windows.Forms.RadioButton rBadministrador;
    }
}