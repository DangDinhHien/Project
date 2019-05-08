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
using WMPLib;


namespace Duoi_Hinh_Bat_Chu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListAnh = new List<string>();
        List<string> ListDapAn = new List<string>();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        string[] DapAn = {
                             "LUCLAC",
                             "NHAHAT",
                             "AOMUA",
                             "BAOTHUC",
                             "BONGDA",
                             //"HONGTAM",
                             //"BACTINH",
                             //"HAILONG",
                             //"XICHLO",
                             //"NGANGU",
                             //"NGUAO",
                             //"TICHPHAN",
                             //"XEHOA",
                             //"COBAP",
                             //"XUONGRONG",
                             //"DETIEN",
                             //"KIEMCHUYEN",
                             //"TAIHOA",
                             //"CONGBO",
                             //"NOKIA",
                             //"HOALUC",
                         };
        int index;
        string luulaidapan;
        List<Button> ListB1 = new List<Button>();
        List<Button> ListB2 = new List<Button>();
        int dem = 0, score = 0;
        List<int> ListDiem = new List<int>();
        string[] Mangquacau = new string[4];

        // WMPLib.WindowsMediaPlayer aa;

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
        bool trangthai = true;

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
                if (trangthai)
                {
                    nhac++;
                    if (nhac == 6)
                    {
                        nhac = 1;
                    }
                    String a = "nhac" + nhac + ".mp3";
                    PlayFile(a);
                }
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // aa = new WMPLib.WindowsMediaPlayer();

            //aa.URL = "emgaimua.mp3";
            //aa.settings.volume = 30;
            //aa.controls.play();
            PlayFile("nhac1.mp3");
            Mangquacau[0] = "Rất chính xác!";
            Mangquacau[1] = "Đúng dồiiiii";
            Mangquacau[2] = "Hay quá!";
            Mangquacau[3] = "Quá hay!";

            for (int i = 0; i < 5; i++)
            {
                ListDapAn.Add(DapAn[i]);
            }
            for (int i = 100; i <= 104; i++)
            {
                ListAnh.Add("Anh\\" + i + ".jpg");
            }
            

            Dungroi();
        }

        // Sự kiện click của hàng dưới
        void b_Click(object sender, EventArgs e)
        {
            string s = "";
            if (((Button)sender).Text != "")
            {
                s = ((Button)sender).Text;
                ((Button)sender).ResetText();
                for (int i = 0; i < ListB2.Count; i++)
                {
                    if (s == ListB2[i].Text && ListB2[i].Enabled == false)
                    {
                        ListB2[i].Enabled = true;

                        break;
                    }
                }
            }
        }

        // Sự kiện click của hàng trên
        void a_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListB1.Count; i++)
            {
                if (ListB1[i].Text == "")
                {
                    ListB1[i].Text = ((Button)(sender)).Text;
                    ((Button)sender).Enabled = false;
                    break;
                }
            }

            bool check = true;
            for (int i = 0; i < ListB1.Count; i++)
            {
                if (ListB1[i].Text == "")
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                // Di kiem tra ket qua
                string s = "";
                for (int i = 0; i < ListB1.Count; i++)
                {
                    s += ListB1[i].Text;
                }

                if (s == luulaidapan)
                {

                    wplayer.URL = "dung.mp3";
                    wplayer.settings.volume = 30;
                    wplayer.controls.play();
                    
                    score += 10;
                    btnScore.Text = "Score: " + score;
                    
                    Dungroi();
                }
                else
                {
                    

                    wplayer.URL = "sai.mp3";
                    wplayer.settings.volume = 30;
                    wplayer.controls.play();
                    Form2 ff = new Form2();
                    ff.ShowDialog();
                }
            }
        }

        private void Dungroi()
        {
            goiy = -1;
            if (ListAnh.Count == 0)
            {
                //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                trangthai = false;
                wplayer.URL = "chienthang.mp3";
                wplayer.settings.volume = 30;
                wplayer.controls.play();
                Player.controls.stop();
                MessageBox.Show("Bạn đã chiến thắng: \nScore: " + score, "Chúc mừng bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
                return;
            }

            //WMPLib.WindowsMediaPlayer aaa = new WMPLib.WindowsMediaPlayer();

            //wplayer.URL = "dung.mp3";
            //wplayer.settings.volume = 30;
            //wplayer.controls.play();

            dem++;
            btnLevel.Text = "Level: " + dem;
            Random rd = new Random();
            index = rd.Next(0, ListAnh.Count);
            pbAnh.BackgroundImage = Image.FromFile(ListAnh[index]);
            pbAnh.BackgroundImageLayout = ImageLayout.Stretch;
            // lblShow.Text = ListDapAn[index];

            //  Hien thi hang tren
            ListB2.Clear();
            flp2.Controls.Clear();
            for (int i = 0; i < 14; i++)
            {
                Button a = new Button();
                a.BackColor = System.Drawing.SystemColors.Desktop;
                a.ForeColor = System.Drawing.Color.YellowGreen;
                a.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
                a.Click += a_Click;
                a.Size = new Size(30, 30);
                ListB2.Add(a);
            }

            // Them chu cai vao hang tren
            for (int i = 0; i < ListDapAn[index].Length; i++)
            {
                ListB2[i].Text = ListDapAn[index][i].ToString();
            }

            // Tiep tuc ramdon nhung tu con lai.
            Random t = new Random();

            for (int i = ListDapAn[index].Length; i < 14; i++)
            {

                char temp = (char)t.Next(65, 90);
                ListB2[i].Text = temp.ToString();

            }
            // Random lai cac text trong button.
            int n = ListB2.Count;
            while (n > 1)
            {
                n--;
                int k = t.Next(0, n + 1);
                string tempp = ListB2[k].Text;
                ListB2[k].Text = ListB2[n].Text;
                ListB2[n].Text = tempp;
            }

            for (int i = 0; i < 14; i++)
            {
                flp2.Controls.Add(ListB2[i]);
            }

            // Hien thi hang duoi

            ListB1.Clear();
            flptemp.Controls.Clear();
            for (int i = 0; i < ListDapAn[index].Length; i++)
            {
                Button b = new Button();
                b.BackColor = System.Drawing.Color.Gray;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
                b.Click += b_Click;
                b.Size = new Size(30, 30);
                ListB1.Add(b);
            }

            for (int i = 0; i < ListB1.Count; i++)
            {
                flptemp.Controls.Add(ListB1[i]);
            }

            // Canh giua flp
            int x = (this.Width - flp2.Width) / 2 - 20 * ListDapAn[index].Length;
            //MessageBox.Show(flptemp.Width.ToString());
            flptemp.Location = new Point(x, flptemp.Location.Y);
            
            luulaidapan = "";
            luulaidapan = ListDapAn[index];
            ListAnh.RemoveAt(index);
            ListDapAn.RemoveAt(index);
        }

        int tin = 0;
        int goiy = -1;
        private void btnGoiy_Click(object sender, EventArgs e)
        {
            
            if (score < 5)
            {
                MessageBox.Show("Điểm còn quá ít bạn êii. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < ListB1.Count; i++)
                {
                    b_Click(ListB1[i], e);
                }
                goiy++;
                if (goiy < luulaidapan.Length - 1)
                {
                    score -= 5;
                    btnScore.Text = "Score: " + score;
                    ListB1[goiy].Text = luulaidapan[goiy].ToString();
                    ListB1[goiy].Enabled = false;
                }
                else
                {
                    score -= 5;
                    Dungroi();
                }
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "sai.mp3";
            wplayer.settings.volume = 30;
            wplayer.controls.play();
            score -= 20;
            Form2 ff = new Form2();
            ff.ShowDialog();
            if (score < 0)
            {
                MessageBox.Show("Game Over!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            btnScore.Text = "Score: " + score;
            Dungroi();
                    
            //Form3 f3 = new Form3();
            //f3.ShowDialog();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangthai = false;
            Player.controls.stop();
            wplayer.controls.stop();
        }

        bool k = true;

        private void pbvolume_Click(object sender, EventArgs e)
        {
            if (k)
            {
                Player.controls.pause();
                pbvolume.BackgroundImage = Properties.Resources.off;
                k = false;
            }
            else
            {
                Player.controls.play();
                pbvolume.BackgroundImage = Properties.Resources.on;
                k = true;
            }
            
        }

        private void pbnext_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
        }

    }
}
