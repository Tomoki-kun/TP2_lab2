
namespace TP2_Lab
{
    partial class FActualizarContra
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
            this.button1 = new System.Windows.Forms.Button();
            this.tBnuevaC = new System.Windows.Forms.TextBox();
            this.tBnuevaC2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar contraseña:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(286, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tBnuevaC
            // 
            this.tBnuevaC.Location = new System.Drawing.Point(130, 107);
            this.tBnuevaC.Name = "tBnuevaC";
            this.tBnuevaC.Size = new System.Drawing.Size(586, 22);
            this.tBnuevaC.TabIndex = 3;
            // 
            // tBnuevaC2
            // 
            this.tBnuevaC2.Location = new System.Drawing.Point(130, 246);
            this.tBnuevaC2.Name = "tBnuevaC2";
            this.tBnuevaC2.PasswordChar = '*';
            this.tBnuevaC2.Size = new System.Drawing.Size(586, 22);
            this.tBnuevaC2.TabIndex = 4;
            // 
            // FActualizarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 388);
            this.Controls.Add(this.tBnuevaC2);
            this.Controls.Add(this.tBnuevaC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FActualizarContra";
            this.Text = "FActualizarContra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tBnuevaC;
        public System.Windows.Forms.TextBox tBnuevaC2;
    }
}