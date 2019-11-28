using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampShot2._0
{
    class Logic
    {
        int cols = 1, coll = 2, num = 15;
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
            if (coll < 15)
                coll++;
            if ((coll % 5 == 0) && (coll != 15))
            {
                cols++;
            }

            drawing.DrawAll(cols, num, coll);
        }
    }
}
