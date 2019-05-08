using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Duoi_Hinh_Bat_Chu
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btnhuongdan_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        WMPLib.WindowsMediaPlayer Player;

        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange += Player_PlayStateChange;
            Player.URL = url;
            Player.settings.volume = 30;
            Player.controls.play();
        }

        int nhac = 1;
        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
                //nhac++;
                //if (nhac == 6)
                //{
                //    nhac = 1;
                //}
                //String a = "nhac" + nhac + ".mp3";
                //PlayFile(a);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //PlayFile("emgaimua.mp3");
            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            //wplayer.URL = "nhac.mp3";
            //wplayer.settings.volume = 30;
            //wplayer.controls.play();
            
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}
