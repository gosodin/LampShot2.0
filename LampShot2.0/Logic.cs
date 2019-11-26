using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampShot2._0
{
    class Logic
    {
        int cols = 1;
        Drawing drawing = new Drawing();
        Form1 frm;
        public void GameStart(Form1 f)
        {
            frm = f;
            frm.RefreshTimer.Enabled = true;
            drawing.AnimStart(frm);
        }
        public void Refresh()
        {
            drawing.DrawAll(cols);
        }
    }
}
