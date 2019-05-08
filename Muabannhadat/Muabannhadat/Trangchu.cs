using Muabannhadat.DataP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muabannhadat
{
    public partial class Trangchu : Form
    {
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public Trangchu(string a)
        {
            Username = a;
            InitializeComponent();
            //Loadtindang();
        }

        public List<tinhienthi> Loadlisttin()
        {
            List<tinhienthi> listtin = new List<tinhienthi>();

            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from Tindang a, BDS b where a.id = b.matin");

            foreach (DataRow item in data.Rows)
            {
                tinhienthi tb = new tinhienthi(item);
                listtin.Add(tb);
            }

            return listtin;
        }

        public List<string> Loadlistduan()
        {
            List<string> listtin = new List<string>();

            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from DuAn");

            foreach (DataRow item in data.Rows)
            {
                string tb = item["ten"].ToString();
                listtin.Add(tb);
            }

            return listtin;
        }

        void Loadtenduan()
        {
            List<string> listtenduan = Loadlistduan();
            foreach (string item in listtenduan)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                
                btn.Text = item;
                

                btn.BackColor = Color.YellowGreen;

                flpduan.Controls.Add(btn);
            }
        }

        void Loadtindang()
        {
            List<tinhienthi> tablelist = Loadlisttin();

            for (int i = 0; i < tablelist.Count; i++)
            {
                if (i > 3) return;
                Button btn = new Button() { Width = 120, Height = 100 };
                btn.Text = tablelist[tablelist.Count - i - 1].Tieude + Environment.NewLine + "\n" + tablelist[tablelist.Count - i - 1].Tentinh + " " + tablelist[tablelist.Count - i - 1].Tenquan + "\n" + tablelist[tablelist.Count - i - 1].Tenduong + Environment.NewLine + "\nGiá: " + tablelist[tablelist.Count - i - 1].Gia.ToString();

                btn.BackColor = Color.LightBlue;

                flptin.Controls.Add(btn);
            }

            //foreach (tinhienthi item in tablelist)
            //{
            //    Button btn = new Button() { Width = 100, Height = 100 };
            //    btn.Text = item.Tieude + Environment.NewLine + "\n" + item.Tentinh + " " + item.Tenquan + "\n" + item.Tenduong + Environment.NewLine + "\nGiá: " + item.Gia.ToString();

            //    btn.BackColor = Color.LightBlue;

            //    flptin.Controls.Add(btn);
            //}
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongtincanhan_Click(object sender, EventArgs e)
        {
            Thongtincanhan f = new Thongtincanhan(Username);
            f.ShowDialog();
        }

        private void đăngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangtin f = new Dangtin(Username);
            f.ShowDialog();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            Loadtindang();
            Loadtenduan();
        }

        private void tìmKiếmBĐSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiem f = new Timkiem();
            f.ShowDialog();
        }

        private void tinTứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại chưa làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
