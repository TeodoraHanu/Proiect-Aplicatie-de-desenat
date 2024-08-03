using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Aplicatie_de_desenat
{
    internal class fisier : Butoane
    {
        private PictureBox fundalPictureBox;


        public fisier(canvas pagina) : base(pagina)
        {
            this.fundalPictureBox = pagina.GetFundalPictureBox();
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (fundalPictureBox != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    using (Bitmap bitmap = new Bitmap(fundalPictureBox.Width, fundalPictureBox.Height))
                    {
                        fundalPictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, fundalPictureBox.Width, fundalPictureBox.Height));

                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        }
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Referința la PictureBox este null.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}