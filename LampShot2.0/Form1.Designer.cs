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
            this.play_but = new System.Windows.Forms.Button();
            this.FrameUpdate = new System.Windows.Forms.Timer(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // play_but
            // 
            this.play_but.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play_but.BackColor = System.Drawing.Color.Transparent;
            this.play_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_but.BackgroundImage")));
            this.play_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_but.FlatAppearance.BorderSize = 0;
            this.play_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_but.Location = new System.Drawing.Point(525, 419);
            this.play_but.Name = "play_but";
            this.play_but.Size = new System.Drawing.Size(250, 250);
            this.play_but.TabIndex = 0;
            this.play_but.UseVisualStyleBackColor = false;
            this.play_but.Click += new System.EventHandler(this.play_but_Click);
            // 
            // FrameUpdate
            // 
            this.FrameUpdate.Interval = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.play_but);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_but;
        public System.Windows.Forms.Timer FrameUpdate;
        public System.Windows.Forms.Timer RefreshTimer;
    }
}

