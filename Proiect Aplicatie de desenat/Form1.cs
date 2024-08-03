using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Aplicatie_de_desenat
{
    public partial class fMain : Form
    {
        private Butoane buttons;
        private AlegeNume alegeNumeForm;
        private canvas canvasForm;
        public fMain()
        {
            InitializeComponent();
            InitializeForm();
            buttons = new Butoane();
            alegeNumeForm = new AlegeNume();

        }
        private void InitializeForm()
        {
            PictureBox pozaFundal = new PictureBox();
            pozaFundal.Dock = DockStyle.Fill; 
            pozaFundal.SizeMode = PictureBoxSizeMode.Zoom;
            pozaFundal.Image = Image.FromFile(@"Poza\\pozaFundal.jpg");
            this.Controls.Add(pozaFundal);
        }

        private void butonJoin_Click(object sender, EventArgs e)
        {
            AlegeNume alegeNumeForm = new AlegeNume();
            DialogResult result = alegeNumeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string player1Name = alegeNumeForm.Player1Name;
                string player2Name = alegeNumeForm.Player2Name;

               
                canvasForm = new canvas(player1Name, player2Name);
                canvasForm.UpdatePlayerLabels(player1Name, player2Name);
                canvasForm.Show();
            }
        }
    }
}