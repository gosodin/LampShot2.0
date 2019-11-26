using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampShot2._0
{
    class Drawing
    {
        Form1 frm;
        public void AnimStart(Form1 f)
        {
            frm = f;
        }
        public void DrawAll(int cols)
        {
            DrawShelf(cols);
            DrawLamp();
            DrawHealth();
        }
        public void DrawLamp()
        {
            
        }
        public void DrawShelf(int cols)
        {
            for (int a = 0; a < cols; a++)
            {
                frm.Controls.Remove(frm.shelf[a]);
                frm.shelf[a].Image = frm.wood;
                frm.shelf[a].Size = new Size(Convert.ToInt32(frm.Size.Width / 1.4), frm.Size.Height / 9);
                frm.shelf[a].SizeMode = PictureBoxSizeMode.StretchImage;
                frm.shelf[a].Location = new Point(frm.Size.Width / 2 - frm.shelf[a].Size.Width / 2, frm.Size.Height - frm.shelf[a].Size.Height * 3 / 2 * (a + a + 1));
                frm.Controls.Add(frm.shelf[a]);
            }
        }
        public void DrawHealth()
        {

        }
    }
}
