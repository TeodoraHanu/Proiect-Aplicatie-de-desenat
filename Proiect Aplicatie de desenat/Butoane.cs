using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Aplicatie_de_desenat
{
    internal class Butoane
    {
        private bool paginaDesenatDeschisa = false;
        private canvas pagina;
        private Pen cursorCreion;
        private Color culoareCurenta = Color.Black;
        public Color CuloareCurenta
        {
            get { return culoareCurenta; }
            set { culoareCurenta = value; }
        }
        public Pen CursorPen
        {
            get { return cursorCreion; }
        }
        public Butoane(canvas pagina)
        {
            this.pagina = pagina;
        }

        public Butoane()
        {
        }

        public virtual void creion_Click()
        {
            cursorCreion = new Pen(CuloareCurenta, 3);
        }

        public virtual void Pensula_Click()
        {
            cursorCreion = new Pen(CuloareCurenta, 7);
        }
        public virtual void UmplereFoaie(canvas pagina)
        {
            if (pagina != null && pagina.GetBitmap() != null && pagina.GetFundalPictureBox() != null)
            {
                Bitmap bitmap = pagina.GetBitmap();
                PictureBox fundalPictureBox = pagina.GetFundalPictureBox();

                if (bitmap != null && fundalPictureBox != null && cursorCreion != null)
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(CuloareCurenta); 
                        fundalPictureBox.Image = bitmap;
                    }
                }
            }
        }




    }
}