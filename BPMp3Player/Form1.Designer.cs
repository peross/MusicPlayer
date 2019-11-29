namespace BPMp3Player
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblUkVrijeme = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVrijeme = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuImageButton13 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblNazivPjesme = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnNowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowseMusic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 548);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 65);
            this.panel5.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(61, 65);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 55);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.progressBar1);
            this.panel6.Controls.Add(this.bunifuImageButton1);
            this.panel6.Controls.Add(this.bunifuProgressBar2);
            this.panel6.Controls.Add(this.lblUkVrijeme);
            this.panel6.Controls.Add(this.lblVrijeme);
            this.panel6.Controls.Add(this.btnPause);
            this.panel6.Controls.Add(this.bunifuImageButton10);
            this.panel6.Controls.Add(this.bunifuImageButton9);
            this.panel6.Controls.Add(this.btnShuffle);
            this.panel6.Controls.Add(this.btnNext);
            this.panel6.Controls.Add(this.btnPlay);
            this.panel6.Controls.Add(this.btnPrevious);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(61, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(891, 65);
            this.panel6.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(203, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(685, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(820, 35);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 23;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(675, 43);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.bunifuProgressBar2.Size = new System.Drawing.Size(139, 10);
            this.bunifuProgressBar2.TabIndex = 22;
            this.bunifuProgressBar2.Value = 100;
            // 
            // lblUkVrijeme
            // 
            this.lblUkVrijeme.AutoSize = true;
            this.lblUkVrijeme.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkVrijeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUkVrijeme.Location = new System.Drawing.Point(845, 16);
            this.lblUkVrijeme.Name = "lblUkVrijeme";
            this.lblUkVrijeme.Size = new System.Drawing.Size(37, 20);
            this.lblUkVrijeme.TabIndex = 21;
            this.lblUkVrijeme.Text = "0:00";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVrijeme.Location = new System.Drawing.Point(203, 16);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(37, 20);
            this.lblVrijeme.TabIndex = 20;
            this.lblVrijeme.Text = "0:00";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.Location = new System.Drawing.Point(448, 35);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(25, 25);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 19;
            this.btnPause.TabStop = false;
            this.btnPause.Zoom = 10;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(644, 35);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 18;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Zoom = 10;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(579, 35);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 17;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.BunifuImageButton9_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.Location = new System.Drawing.Point(548, 35);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(25, 25);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShuffle.TabIndex = 16;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Zoom = 10;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(479, 35);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 15;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(417, 35);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 25);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 14;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(386, 35);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 25);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 10;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel7.Controls.Add(this.bunifuImageButton13);
            this.panel7.Location = new System.Drawing.Point(261, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(691, 38);
            this.panel7.TabIndex = 4;
            // 
            // bunifuImageButton13
            // 
            this.bunifuImageButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuImageButton13.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton13.Image")));
            this.bunifuImageButton13.ImageActive = null;
            this.bunifuImageButton13.Location = new System.Drawing.Point(665, 3);
            this.bunifuImageButton13.Name = "bunifuImageButton13";
            this.bunifuImageButton13.Size = new System.Drawing.Size(23, 23);
            this.bunifuImageButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton13.TabIndex = 8;
            this.bunifuImageButton13.TabStop = false;
            this.bunifuImageButton13.Zoom = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel8.Controls.Add(this.lblNazivPjesme);
            this.panel8.Controls.Add(this.bunifuCustomLabel6);
            this.panel8.Location = new System.Drawing.Point(261, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(691, 77);
            this.panel8.TabIndex = 6;
            // 
            // lblNazivPjesme
            // 
            this.lblNazivPjesme.AutoSize = true;
            this.lblNazivPjesme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNazivPjesme.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivPjesme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lblNazivPjesme.Location = new System.Drawing.Point(141, 36);
            this.lblNazivPjesme.Name = "lblNazivPjesme";
            this.lblNazivPjesme.Size = new System.Drawing.Size(109, 20);
            this.lblNazivPjesme.TabIndex = 7;
            this.lblNazivPjesme.Text = " Naziv pjesme";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(16, 37);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(119, 19);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "NOW PLAYING";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuImageButton4);
            this.panel4.Controls.Add(this.bunifuImageButton3);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 115);
            this.panel4.TabIndex = 1;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(237, 76);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(30, 20);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 4;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(198, 76);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(30, 20);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 3;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 76);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "BP Player";
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNowPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNowPlaying.BorderRadius = 0;
            this.btnNowPlaying.ButtonText = "      Now Playing";
            this.btnNowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.btnNowPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.Iconimage = null;
            this.btnNowPlaying.Iconimage_right = null;
            this.btnNowPlaying.Iconimage_right_Selected = null;
            this.btnNowPlaying.Iconimage_Selected = null;
            this.btnNowPlaying.IconMarginLeft = 0;
            this.btnNowPlaying.IconMarginRight = 0;
            this.btnNowPlaying.IconRightVisible = true;
            this.btnNowPlaying.IconRightZoom = 0D;
            this.btnNowPlaying.IconVisible = true;
            this.btnNowPlaying.IconZoom = 90D;
            this.btnNowPlaying.IsTab = true;
            this.btnNowPlaying.Location = new System.Drawing.Point(0, 115);
            this.btnNowPlaying.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnNowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNowPlaying.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNowPlaying.selected = false;
            this.btnNowPlaying.Size = new System.Drawing.Size(200, 59);
            this.btnNowPlaying.TabIndex = 2;
            this.btnNowPlaying.Text = "      Now Playing";
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNowPlaying.TextFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // btnBrowseMusic
            // 
            this.btnBrowseMusic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBrowseMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnBrowseMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseMusic.BorderRadius = 0;
            this.btnBrowseMusic.ButtonText = "      Browse Music";
            this.btnBrowseMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseMusic.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseMusic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseMusic.Iconimage = null;
            this.btnBrowseMusic.Iconimage_right = null;
            this.btnBrowseMusic.Iconimage_right_Selected = null;
            this.btnBrowseMusic.Iconimage_Selected = null;
            this.btnBrowseMusic.IconMarginLeft = 0;
            this.btnBrowseMusic.IconMarginRight = 0;
            this.btnBrowseMusic.IconRightVisible = true;
            this.btnBrowseMusic.IconRightZoom = 0D;
            this.btnBrowseMusic.IconVisible = true;
            this.btnBrowseMusic.IconZoom = 90D;
            this.btnBrowseMusic.IsTab = true;
            this.btnBrowseMusic.Location = new System.Drawing.Point(0, 174);
            this.btnBrowseMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseMusic.Name = "btnBrowseMusic";
            this.btnBrowseMusic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnBrowseMusic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBrowseMusic.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowseMusic.selected = false;
            this.btnBrowseMusic.Size = new System.Drawing.Size(200, 59);
            this.btnBrowseMusic.TabIndex = 3;
            this.btnBrowseMusic.Text = "      Browse Music";
            this.btnBrowseMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseMusic.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowseMusic.TextFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseMusic.Click += new System.EventHandler(this.btnBrowseMusic_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.btnBrowseMusic);
            this.panel3.Controls.Add(this.btnNowPlaying);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(61, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 483);
            this.panel3.TabIndex = 5;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Playlist";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 233);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 59);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "      Playlist";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.lstPlaylist);
            this.panel9.Location = new System.Drawing.Point(261, 115);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(691, 368);
            this.panel9.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lstPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.ItemHeight = 17;
            this.lstPlaylist.Location = new System.Drawing.Point(3, 12);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(684, 344);
            this.lstPlaylist.TabIndex = 1;
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel7;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 548);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton13)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUkVrijeme;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVrijeme;
        private Bunifu.Framework.UI.BunifuImageButton btnPause;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
        private Bunifu.Framework.UI.BunifuImageButton btnShuffle;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton13;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNazivPjesme;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNowPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseMusic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

