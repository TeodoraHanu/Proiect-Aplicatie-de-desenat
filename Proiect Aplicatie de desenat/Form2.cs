using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Aplicatie_de_desenat
{
    public partial class canvas : Form
    {
        private Butoane buttons;
        private Graphics graphics;
        bool cursorMiscare = false;
        private Pen cursorCreion = new Pen(Color.Black, 5);
        Bitmap Bitmap = new Bitmap(1920, 1080);
        private Bitmap drawingLayer;
        private string player1Name;
        private string player2Name;
        public Label LabelPlayerUnu { get { return labelPlayerUnu; } }
        public Label LabelPlayerDoi { get { return labelPlayerDoi; } }

        public Bitmap GetBitmap()
        {
            return Bitmap;
        }
        public PictureBox GetFundalPictureBox()
        {
            return fundal;
        }


        public canvas(string player1Name, string player2Name)
        {
            InitializeComponent();
            buttons = new Butoane(this);
            drawingLayer = new Bitmap(Bitmap);
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }


        private void btn_Negru_Click(object sender, EventArgs e)
        {


            PictureBox my_picture = (PictureBox)sender;
            buttons.CuloareCurenta = my_picture.BackColor;
            cursorCreion.Color = buttons.CuloareCurenta;
            culoareAleasa.BackColor = buttons.CuloareCurenta;

        }
        int x;
        int y;
        private void btn_Negru_MouseDown(object sender, MouseEventArgs e)
        {
          
            
            if (cursorMiscare == true)
            {
                cursorMiscare = false;
            }
            else
            {
                cursorMiscare = true;
            }
           // x = e.X; y = e.Y;
        }

        private void btn_Negru_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (cursorMiscare == true)
            {
                Graphics g = Graphics.FromImage(Bitmap);
               // g.DrawLine(cursorCreion, e.X, e.Y, x, y);
                g.DrawRectangle(cursorCreion, e.X, e.Y, 1, 1);
                fundal.Image = Bitmap;
              //  x = e.X; y = e.Y;
            }
        
        }


        private void creion_Click(object sender, EventArgs e)
        {
            buttons.creion_Click();
            graphics = fundal.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorCreion = buttons.CursorPen;

        }

        private void Pensula_Click(object sender, EventArgs e)
        {
            buttons.Pensula_Click();
            graphics = fundal.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorCreion = buttons.CursorPen; 

        }

        private void gumaDeSters_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
            Bitmap = new Bitmap(1920, 1080);
            fundal.Image = Bitmap;
        

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            fisier fisierHandler = new fisier(this);
            fisierHandler.btnSave_Click(sender, e);
        }

        public void UpdatePlayerLabels(string player1Name, string player2Name)
        {

            LabelPlayerUnu.Text = "Player 1: " + player1Name;
            LabelPlayerDoi.Text = "Player 2: " + player2Name;
        }

        private void umplereFoaie_Click(object sender, EventArgs e)
        {
            buttons.UmplereFoaie(this);
        }

        private void labelPlayerUnu_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayerDoi_Click(object sender, EventArgs e)
        {

        }
    }
}