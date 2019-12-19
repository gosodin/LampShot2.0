using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampShot2._0
{
    public partial class Form1 : Form
    {
        //Texture
        public Bitmap BGround = null;
        public Bitmap lampst = Properties.Resources.LampStandart;
        public Bitmap lampstb = Properties.Resources.LampStandartBroke;
        public Bitmap lampstl = Properties.Resources.LampStandartLight;
        public Bitmap wood = Properties.Resources.ShelfWood;
        public Bitmap healthY = Properties.Resources.Health;
        public Bitmap healthN = Properties.Resources.HealthBroke;
        public PictureBox[] shelf = new PictureBox[3];
        public PictureBox[] lamps = new PictureBox[15];
        public PictureBox[] healths = new PictureBox[3];
        //Game
        Settings settings = new Settings();
        Logic logic = new Logic();
        //Facts
        string[] facts = new string[20]; 
        public Form1()
        {
            InitializeComponent();
            facts[0] = "«Столетняя лампочка» или «лампочка из Ливермора», как прозвали ее в народе, горит непрерывно на малой мощности (4 Bаттa), в глубоком недокале, при очень низком КПД. Первоначально она использовалась для ночного освещения и пару раз меняла место расположения. Последний раз в 1976 году, для чего она выключалась на 22 минуты.";
            for (int a = 0; a < 15; a++)
            {
                if (a < 3)
                {
                    healths[a] = new PictureBox();
                    healths[a].BackColor = Color.Transparent;
                    healths[a].SizeMode = PictureBoxSizeMode.Zoom;
                    healths[a].Visible = false;
                    Controls.Add(healths[a]);
                    shelf[a] = new PictureBox();
                    shelf[a].BackColor = Color.Transparent;
                    shelf[a].SizeMode = PictureBoxSizeMode.Zoom;
                    shelf[a].Visible = false;
                    Controls.Add(shelf[a]);

                }
                lamps[a] = new PictureBox();
                lamps[a].BackColor = Color.Transparent;
                lamps[a].SizeMode = PictureBoxSizeMode.Zoom;
                lamps[a].Click += new EventHandler(Lamps_Click);
                lamps[a].Visible = false;
                Controls.Add(lamps[a]);
            }
        }

        private void Lamps_Click(object sender, EventArgs e)
        {
            logic.LampClick(sender);
        }

        private void play_but_Click(object sender, EventArgs e)
        {
            logic.GameStart(this);
            play_but.Visible = false;
            SetBut.Visible = false;
            label1.Visible = false;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            logic.Refresh();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            logic.Resize();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            if (settings.num == 5)
                settings.num = -1;
            settings.num++;
            BG.BackgroundImage = settings.BG[settings.num];
            BGround = (Bitmap)BG.BackgroundImage;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            settings.CloseSet();
        }

        private void SetBut_Click(object sender, EventArgs e)
        {
            settings.Open(this);
        }
        public void Facts()
        {
            Random r = new Random();
            //int a = r.Next(20);
            int a = 0;
            fact.Text = facts[a];
            KnowYou.Visible = true;
            fact.Visible = true;
            Sett.Visible = true;
        }

        private void fact_Resize(object sender, EventArgs e)
        {
            fact.Font = new Font(fact.Font.FontFamily, Width / 60, fact.Font.Style);
        }
    }
}