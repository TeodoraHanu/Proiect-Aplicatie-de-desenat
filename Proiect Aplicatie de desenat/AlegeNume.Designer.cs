namespace Proiect_Aplicatie_de_desenat
{
    partial class AlegeNume
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.player2NameTxtBox = new System.Windows.Forms.TextBox();
            this.player1NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player2ChooseNamelbl = new System.Windows.Forms.Label();
            this.player1ChoseNameLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.player2NameTxtBox);
            this.panel1.Controls.Add(this.player1NameTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.player2ChooseNamelbl);
            this.panel1.Controls.Add(this.player1ChoseNameLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 299);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player2NameTxtBox
            // 
            this.player2NameTxtBox.Location = new System.Drawing.Point(241, 159);
            this.player2NameTxtBox.Name = "player2NameTxtBox";
            this.player2NameTxtBox.Size = new System.Drawing.Size(123, 20);
            this.player2NameTxtBox.TabIndex = 1;
            this.player2NameTxtBox.TextChanged += new System.EventHandler(this.player2NameTxtBox_TextChanged);
            // 
            // player1NameTxtBox
            // 
            this.player1NameTxtBox.Location = new System.Drawing.Point(42, 159);
            this.player1NameTxtBox.Name = "player1NameTxtBox";
            this.player1NameTxtBox.Size = new System.Drawing.Size(123, 20);
            this.player1NameTxtBox.TabIndex = 1;
            this.player1NameTxtBox.TextChanged += new System.EventHandler(this.player1NameTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose you name:";
            // 
            // player2ChooseNamelbl
            // 
            this.player2ChooseNamelbl.AutoSize = true;
            this.player2ChooseNamelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ChooseNamelbl.ForeColor = System.Drawing.Color.White;
            this.player2ChooseNamelbl.Location = new System.Drawing.Point(263, 123);
            this.player2ChooseNamelbl.Name = "player2ChooseNamelbl";
            this.player2ChooseNamelbl.Size = new System.Drawing.Size(69, 19);
            this.player2ChooseNamelbl.TabIndex = 0;
            this.player2ChooseNamelbl.Text = "Player2:";
            // 
            // player1ChoseNameLbl
            // 
            this.player1ChoseNameLbl.AutoSize = true;
            this.player1ChoseNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ChoseNameLbl.ForeColor = System.Drawing.Color.White;
            this.player1ChoseNameLbl.Location = new System.Drawing.Point(68, 123);
            this.player1ChoseNameLbl.Name = "player1ChoseNameLbl";
            this.player1ChoseNameLbl.Size = new System.Drawing.Size(69, 19);
            this.player1ChoseNameLbl.TabIndex = 0;
            this.player1ChoseNameLbl.Text = "Player1:";
            // 
            // AlegeNume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(406, 295);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlegeNume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlegeNume";
            this.Load += new System.EventHandler(this.AlegeNume_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox player2NameTxtBox;
        public System.Windows.Forms.TextBox player1NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2ChooseNamelbl;
        private System.Windows.Forms.Label player1ChoseNameLbl;
    }
}