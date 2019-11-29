using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMp3Player
{
    public partial class Form1 : Form
    {
        string[] file, path;
        public string item, length;
        public WMPLib.IWMPMedia media;

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
            {
                double dur = axWindowsMediaPlayer1.currentMedia.duration;
                progressBar1.Maximum = (int)dur;
            }
            if (e.newState == 1)
            {
                if (lstPlaylist.SelectedIndex != lstPlaylist.Items.Count - 1)
                {
                    BeginInvoke(new Action(() => {
                        lstPlaylist.SelectedIndex = lstPlaylist.SelectedIndex + 1;
                        axWindowsMediaPlayer1.URL = path[lstPlaylist.SelectedIndex];
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        lblNazivPjesme.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
                    }));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            lblVrijeme.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            lblUkVrijeme.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = path[lstPlaylist.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblNazivPjesme.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
        }

        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 684;
            pictureBox1.Height = 350;
            pictureBox1.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            Point point = progressBar1.PointToClient(Cursor.Position);
            progressBar1.Value = progressBar1.Minimum + (progressBar1.Maximum - progressBar1.Minimum) * point.X / progressBar1.Width;
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch { Exception ex; }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => {
                lstPlaylist.SelectedIndex = lstPlaylist.SelectedIndex + 1;
                axWindowsMediaPlayer1.URL = path[lstPlaylist.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                lblNazivPjesme.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
            }));
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => {
                lstPlaylist.SelectedIndex = lstPlaylist.SelectedIndex - 1;
                axWindowsMediaPlayer1.URL = path[lstPlaylist.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                lblNazivPjesme.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
            }));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File (*.wav)|*.wav|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                
                int index = 1;
                for (int i = 0; i < file.Length; i++)
                {
                    lstPlaylist.Items.Add(index + ". " + Path.GetFileNameWithoutExtension(file[i]));
                    index++;
                }
            }
        }
    }
}
