namespace LampShot2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FrameUpdate = new System.Windows.Forms.Timer(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.scorelab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.BG = new System.Windows.Forms.PictureBox();
            this.Sett = new System.Windows.Forms.PictureBox();
            this.SetBut = new System.Windows.Forms.Button();
            this.play_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sett)).BeginInit();
            this.SuspendLayout();
            // 
            // FrameUpdate
            // 
            this.FrameUpdate.Interval = 15;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 5000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // scorelab
            // 
            this.scorelab.AutoSize = true;
            this.scorelab.BackColor = System.Drawing.Color.Transparent;
            this.scorelab.Dock = System.Windows.Forms.DockStyle.Right;
            this.scorelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scorelab.ForeColor = System.Drawing.Color.OrangeRed;
            this.scorelab.Location = new System.Drawing.Point(1165, 0);
            this.scorelab.Name = "scorelab";
            this.scorelab.Size = new System.Drawing.Size(99, 108);
            this.scorelab.TabIndex = 1;
            this.scorelab.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("beer money", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 264);
            this.label1.TabIndex = 3;
            this.label1.Text = "LampShot";
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.AutoSize = true;
            this.Ok.BackColor = System.Drawing.Color.White;
            this.Ok.BackgroundImage = global::LampShot2._0.Properties.Resources.Ok;
            this.Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ok.FlatAppearance.BorderSize = 0;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(576, 457);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(165, 153);
            this.Ok.TabIndex = 6;
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Visible = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // BG
            // 
            this.BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BG.BackColor = System.Drawing.Color.Silver;
            this.BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BG.Location = new System.Drawing.Point(453, 159);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(400, 225);
            this.BG.TabIndex = 5;
            this.BG.TabStop = false;
            this.BG.Visible = false;
            this.BG.Click += new System.EventHandler(this.BG_Click);
            // 
            // Sett
            // 
            this.Sett.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sett.BackColor = System.Drawing.Color.Transparent;
            this.Sett.BackgroundImage = global::LampShot2._0.Properties.Resources.Sett;
            this.Sett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sett.Location = new System.Drawing.Point(348, 51);
            this.Sett.Name = "Sett";
            this.Sett.Size = new System.Drawing.Size(600, 618);
            this.Sett.TabIndex = 4;
            this.Sett.TabStop = false;
            this.Sett.Visible = false;
            // 
            // SetBut
            // 
            this.SetBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetBut.BackColor = System.Drawing.Color.Transparent;
            this.SetBut.BackgroundImage = global::LampShot2._0.Properties.Resources.But_Settings;
            this.SetBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetBut.FlatAppearance.BorderSize = 0;
            this.SetBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBut.Location = new System.Drawing.Point(903, 519);
            this.SetBut.MaximumSize = new System.Drawing.Size(200, 200);
            this.SetBut.Name = "SetBut";
            this.SetBut.Size = new System.Drawing.Size(150, 150);
            this.SetBut.TabIndex = 2;
            this.SetBut.UseVisualStyleBackColor = false;
            this.SetBut.Click += new System.EventHandler(this.SetBut_Click);
            // 
            // play_but
            // 
            this.play_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play_but.BackColor = System.Drawing.Color.Transparent;
            this.play_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_but.BackgroundImage")));
            this.play_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_but.FlatAppearance.BorderSize = 0;
            this.play_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_but.Location = new System.Drawing.Point(525, 419);
            this.play_but.Name = "play_but";
            this.play_but.Size = new System.Drawing.Size(250, 250);
            this.play_but.TabIndex = 0;
            this.play_but.UseVisualStyleBackColor = false;
            this.play_but.Click += new System.EventHandler(this.play_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.BG);
            this.Controls.Add(this.Sett);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBut);
            this.Controls.Add(this.scorelab);
            this.Controls.Add(this.play_but);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sett)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer FrameUpdate;
        public System.Windows.Forms.Timer RefreshTimer;
        public System.Windows.Forms.Label scorelab;
        public System.Windows.Forms.PictureBox Sett;
        public System.Windows.Forms.PictureBox BG;
        public System.Windows.Forms.Button Ok;
        public System.Windows.Forms.Button SetBut;
        public System.Windows.Forms.Button play_but;
        public System.Windows.Forms.Label label1;
    }
}

