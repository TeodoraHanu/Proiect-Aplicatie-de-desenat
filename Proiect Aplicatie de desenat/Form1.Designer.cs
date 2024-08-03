namespace Proiect_Aplicatie_de_desenat
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pozaFundal = new System.Windows.Forms.PictureBox();
            this.butonJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pozaFundal)).BeginInit();
            this.SuspendLayout();
            // 
            // pozaFundal
            // 
            this.pozaFundal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pozaFundal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pozaFundal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pozaFundal.Image = ((System.Drawing.Image)(resources.GetObject("pozaFundal.Image")));
            this.pozaFundal.Location = new System.Drawing.Point(0, 0);
            this.pozaFundal.Name = "pozaFundal";
            this.pozaFundal.Size = new System.Drawing.Size(795, 450);
            this.pozaFundal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pozaFundal.TabIndex = 0;
            this.pozaFundal.TabStop = false;
            // 
            // butonJoin
            // 
            this.butonJoin.BackColor = System.Drawing.Color.Plum;
            this.butonJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonJoin.Location = new System.Drawing.Point(331, 226);
            this.butonJoin.Name = "butonJoin";
            this.butonJoin.Size = new System.Drawing.Size(127, 45);
            this.butonJoin.TabIndex = 2;
            this.butonJoin.Text = "Join";
            this.butonJoin.UseVisualStyleBackColor = false;
            this.butonJoin.Click += new System.EventHandler(this.butonJoin_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.butonJoin);
            this.Controls.Add(this.pozaFundal);
            this.Name = "fMain";
            this.Text = "DrawPlayTeo";
            ((System.ComponentModel.ISupportInitialize)(this.pozaFundal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pozaFundal;
        private System.Windows.Forms.Button butonJoin;
    }
}

