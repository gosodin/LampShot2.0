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
        public void DrawAll(int cols, int num, int coll)
        {
            DrawShelf(cols);
            DrawLamp(coll, num, cols);
            DrawHealth();
        }
        public void DrawLamp(int coll, int num, int cols)
        {
            for (int a = 0, y = 0, s = 0; a < coll; a++)
            {
                if (y == 6 && s < cols)
                {
                    y = 0;
                    s++;
                }
                y++;
                frm.Controls.Add(frm.lamps[a]);
                frm.lamps[a].Size = new Size(frm.Size.Height / 6, frm.Size.Height / 6);
                //frm.lamps[a].Location = new Point((frm.shelf[s].Location.X + frm.shelf[s].Size.Width / coll * a) + (frm.shelf[s].Size.Width / coll / 2) - (frm.lamps[a].Size.Width / 2), frm.shelf[s].Location.Y - frm.lamps[a].Size.Height + 1);
                frm.lamps[a].Location = new Point(a * (frm.shelf[s].Location.X + frm.shelf[s].Size.Width / ((coll - (5 * s - 5)) / 2)) + frm.shelf[s].Size.Width / ((coll - (5 * s - 5)) / 2) - frm.lamps[a].Size.Width / 2, frm.shelf[s].Location.Y - frm.lamps[a].Size.Height + 1);
                frm.lamps[a].Image = frm.lampst;
                if (a == num)
                    frm.lamps[a].Image = frm.lampstl;
            }
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
