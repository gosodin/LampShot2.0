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
        int cols, coll, num, score,health;
        Drawing drawing = new Drawing();
        Form1 frm;
        private bool scoreStop = true;
        private bool GameStarted = false;

        public void GameStart(Form1 f)
        {
            health = 3; coll = 2; cols = 1; num = 15; score = 0;
            frm = f;
            frm.BackgroundImage = frm.BGround;
            frm.Cursor = Cursors.Cross;
            GameStarted = true;
            frm.RefreshTimer.Enabled = true;
            drawing.AnimStart(frm);
            frm.scorelab.Text = Convert.ToString(score);
            Refresh();
        }
        public void Refresh()
        {
            if (frm.RefreshTimer.Interval > 600)
                frm.RefreshTimer.Interval -= 100;
            Random rand = new Random();
            if (coll <= 14)
                coll++;
            if ((coll % 5 == 0) && (coll != 15))
            {
                cols++;
            }
            if (scoreStop == false)
            {
                health--;
                drawing.DrawHealth(health);
            }
            scoreStop = false;
            num = rand.Next(coll);
            if (health == 0)
                GameStop();
            else
            drawing.DrawAll(cols, num, coll,health);
        }
        public void LampClick(object sender)
        {
            PictureBox l = sender as PictureBox;
            l.Image = frm.lampstb;
            if (l.Location != frm.lamps[num].Location)
            {
                health--;
                drawing.DrawHealth(health);
            }
            if (scoreStop == false && l.Location == frm.lamps[num].Location)
            {
                score++;
                frm.scorelab.Text = Convert.ToString(score);
                scoreStop = true;
            }
            if (health == 0)
                GameStop();
        }
        public void Resize()
        {
            if (GameStarted)
                drawing.DrawAll(cols, num, coll,health);
        }
        public void GameStop()
        {
            frm.RefreshTimer.Enabled = false;
            GameStarted = false;
            for (int a = 0; a < 15; a++)
            {
                if (a < 3)
                {
                    frm.healths[a].Visible = false;
                    frm.shelf[a].Visible = false;
                }
                frm.lamps[a].Visible = false;
            }
            frm.BackgroundImage = null;
            frm.play_but.Visible = true;
            frm.SetBut.Visible = true;
            frm.label1.Visible = true;
        }
    }
}
