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
        public void DrawAll(int cols, int num, int coll, int healths)

        {
            DrawShelf(cols);
            DrawLamp(coll, num, cols);
            DrawHealth(healths);
        }
        public void DrawLamp(int coll, int num, int cols)
        {
            for (int a = 0, s = 0, col = 0; a < coll; a++)
            {
                if (a % 5 == 0 && a != 0)
                    s++;
                col = coll;
                if ((coll > 5 && a < 5) || (coll > 9 && a < 10))
                    col = 5;
                if (a > 4 && coll < 10)
                    col = coll - 5;
                if (a > 9)
                    col = coll - 10;
                frm.lamps[a].Size = new Size(frm.Size.Height / 6, frm.Size.Height / 6);
                frm.lamps[a].Location = new Point(frm.shelf[s].Location.X + frm.shelf[s].Width / (col + 1) * (a + 1 - s * 5) - (frm.lamps[a].Width / 2), frm.shelf[s].Location.Y - frm.lamps[a].Height);
                frm.lamps[a].Image = frm.lampst;
                if (a == num)
                    frm.lamps[a].Image = frm.lampstl;
                frm.lamps[a].Visible = true;
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
                frm.shelf[a].Visible = true;
            }
        }
        public void DrawHealth(int healths)
        {
            int loc = frm.Width / 10;
            int y = loc;
            for (int a = 0; a < 3; a++)
            {
                if (healths>a)
                frm.healths[a].Image = frm.healthY;
                else
                    frm.healths[a].Image = frm.healthN;
                frm.healths[a].Size = new Size(loc, loc);
                frm.healths[a].Location = new Point(10, loc / 5 + 2 * (loc * a));
                y += loc * a;
                frm.healths[a].Visible = true;
            }
        }
    }
}
