using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampShot2._0
{
    class Logic
    {
        int cols = 1, coll = 2, num = 15, score = 0;
        Drawing drawing = new Drawing();
        Form1 frm;
        private bool scoreStop = false;
        private bool GameStarted = false;

        public void GameStart(Form1 f)
        {
            frm = f;
            frm.BackgroundImage = frm.BGround;
            GameStarted = true;
            frm.RefreshTimer.Enabled = true;
            drawing.AnimStart(frm);
        }
        public void Refresh()
        {
            scoreStop = false;
            if (frm.RefreshTimer.Interval > 500)
                frm.RefreshTimer.Interval -= 100;
            Random rand = new Random();
            num = rand.Next(coll);
            if (coll <= 14)
                coll++;
            if ((coll % 5 == 0) && (coll != 15))
            {
                cols++;
            }

            drawing.DrawAll(cols, num, coll);
        }
        public void LampClick(object sender)
        {
            PictureBox l = sender as PictureBox;
            l.Image = frm.lampstb;
            if (scoreStop == false && l.Location == frm.lamps[num].Location)
            {
                score++;
                frm.scorelab.Text = Convert.ToString(score);
                scoreStop = true;
            }
        }
        public void Resize()
        {
            if (GameStarted)
                drawing.DrawAll(cols, num, coll);
        }
    }
}
