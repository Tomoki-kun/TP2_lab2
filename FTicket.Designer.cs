
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBTicket = new System.Windows.Forms.ListBox();
            this.pBfotoProp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfotoProp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lBTicket
            // 
            this.lBTicket.FormattingEnabled = true;
            this.lBTicket.ItemHeight = 16;
            this.lBTicket.Location = new System.Drawing.Point(12, 166);
            this.lBTicket.Name = "lBTicket";
            this.lBTicket.Size = new System.Drawing.Size(797, 404);
            this.lBTicket.TabIndex = 1;
            // 
            // pBfotoProp
            // 
            this.pBfotoProp.Location = new System.Drawing.Point(853, 186);
            this.pBfotoProp.Name = "pBfotoProp";
            this.pBfotoProp.Size = new System.Drawing.Size(190, 272);
            this.pBfotoProp.TabIndex = 2;
            this.pBfotoProp.TabStop = false;
            // 
            // FTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 580);
            this.Controls.Add(this.pBfotoProp);
            this.Controls.Add(this.lBTicket);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FTicket";
            this.Text = "FTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfotoProp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox lBTicket;
        public System.Windows.Forms.PictureBox pBfotoProp;
    }
}