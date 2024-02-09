
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
            this.pBfotoProp = new System.Windows.Forms.PictureBox();
            this.lBticket = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfotoProp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pBfotoProp
            // 
            this.pBfotoProp.Location = new System.Drawing.Point(481, 173);
            this.pBfotoProp.Name = "pBfotoProp";
            this.pBfotoProp.Size = new System.Drawing.Size(190, 272);
            this.pBfotoProp.TabIndex = 2;
            this.pBfotoProp.TabStop = false;
            // 
            // lBticket
            // 
            this.lBticket.FormattingEnabled = true;
            this.lBticket.ItemHeight = 16;
            this.lBticket.Location = new System.Drawing.Point(12, 173);
            this.lBticket.Name = "lBticket";
            this.lBticket.Size = new System.Drawing.Size(463, 404);
            this.lBticket.TabIndex = 3;
            // 
            // FTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 580);
            this.Controls.Add(this.lBticket);
            this.Controls.Add(this.pBfotoProp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FTicket";
            this.Text = "FTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfotoProp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pBfotoProp;
        public System.Windows.Forms.ListBox lBticket;
    }
}