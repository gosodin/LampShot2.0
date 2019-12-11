using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LampShot2._0
{
    class Settings
    {
        Form1 frm;
        public int num = 0;
        public Bitmap [] BG = new Bitmap[6] {Properties.Resources.Sky, Properties.Resources.Space, Properties.Resources.Summer, Properties.Resources.Autumn, Properties.Resources.Winter, Properties.Resources.Spring};
        public void Open(Form1 f)
        {
            frm = f;
            frm.BG.Visible = true;
            frm.Ok.Visible = true;
            frm.Sett.Visible = true;
        }
        public void CloseSet()
        {
            frm.Ok.Visible = false;
            frm.Sett.Visible = false;
            frm.BG.Visible = false;
        }
    }
}
