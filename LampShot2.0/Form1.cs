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
        public Bitmap lampst = Properties.Resources.LampStandart;
        public Bitmap lampstb = Properties.Resources.LampStandartBroke;
        public Bitmap lampstl = Properties.Resources.LampStandartLight;
        public Bitmap wood = Properties.Resources.ShelfWood;
        public PictureBox[] shelf = new PictureBox[3];
        public PictureBox[] lamps = new PictureBox[15];
        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
            for (int a = 0; a < 15; a++)
            {
                if (a < 3)
                {
                    shelf[a] = new PictureBox();
                    shelf[a].SizeMode = PictureBoxSizeMode.Zoom;
                    Controls.Add(shelf[a]);
                }
                lamps[a] = new PictureBox();
                lamps[a].SizeMode = PictureBoxSizeMode.Zoom;
                lamps[a].Click += new EventHandler(Lamps_Click);
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
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            logic.Refresh();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            logic.Resize();
        }
    }
}