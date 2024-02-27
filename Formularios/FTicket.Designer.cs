
namespace TP2_Lab
{
    partial class FTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTicket));
            this.lBticket = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lBticket
            // 
            this.lBticket.FormattingEnabled = true;
            this.lBticket.ItemHeight = 16;
            this.lBticket.Location = new System.Drawing.Point(3, 3);
            this.lBticket.Name = "lBticket";
            this.lBticket.Size = new System.Drawing.Size(505, 324);
            this.lBticket.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.Location = new System.Drawing.Point(39, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Aceptar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Propiedad que se alquila:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(84, 369);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(314, 144);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // FTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 580);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lBticket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTicket";
            this.Text = "FTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox lBticket;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}