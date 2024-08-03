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
    public partial class AlegeNume : Form
    {


        public string Player1Name
        {
            get { return player1NameTxtBox.Text; }
        }

        public string Player2Name
        {
            get { return player2NameTxtBox.Text; }
        }

        public AlegeNume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(player1NameTxtBox.Text)) && !(string.IsNullOrEmpty(player2NameTxtBox.Text)))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void player1NameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2NameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AlegeNume_Load(object sender, EventArgs e)
        {

        }
    }
}