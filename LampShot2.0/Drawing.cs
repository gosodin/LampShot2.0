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
        int y = 0;
        public void AnimStart(Form1 f)
        {
            frm = f;
        }
        public void DrawAll(int cols, int num, int coll)

        {
            DrawShelf(cols);
            DrawLamp(coll, num, cols);
            DrawHealth();
        }
        public void DrawLamp(int coll, int num, int cols)
        {
            for (int a = 0,s = 0; a < coll; a++)
            {
                if (a % 5 == 0 && a != 0)
                    s++;
                frm.lamps[a].Size = new Size(frm.Size.Height / 6, frm.Size.Height / 6);
                frm.lamps[a].Location = new Point(frm.shelf[s].Location.X + frm.shelf[s].Width / (coll + 1 -(s * 5)) * (a + 1 - (s * 5)) - (frm.lamps[a].Width / 2),frm.shelf[s].Location.Y - frm.lamps[a].Height);
                frm.lamps[a].Image = frm.lampst;
                if (a == num)
                    frm.lamps[a].Image = frm.lampstl;
            }
        }
        public void DrawShelf(int cols)
        {
            for (int a = 0; a < cols; a++)
            {
                frm.shelf[a].Image = frm.wood;
                frm.shelf[a].Size = new Size(Convert.ToInt32(frm.Size.Width / 1.4), frm.Size.Height / 9);
                frm.shelf[a].SizeMode = PictureBoxSizeMode.StretchImage;
                frm.shelf[a].Location = new Point(frm.Size.Width / 2 - frm.shelf[a].Size.Width / 2, frm.Size.Height - frm.shelf[a].Size.Height * 3 / 2 * (a + a + 1));
            }
        }
        public void DrawHealth()
        {

        }
    }
}
