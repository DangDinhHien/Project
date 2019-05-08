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
    public partial class Dangtin : Form
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public Dangtin(string a)
        {
            username = a;
            InitializeComponent();
            Loadloaitin();
            LoadBDS();
            Loadtendichvu();
            Loadtinh();
        }

        void Loadtinh()
        {
            string sql = "select * from Tinh";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            List<string> listtinh = new List<string>();
            foreach (DataRow item in data.Rows)
            {
                string temp;
                temp = item["tentinh"].ToString();
                listtinh.Add(temp);
            }

            cmbtinh.DataSource = listtinh;
        }

        void Loadtendichvu()
        {
            cmbtendichvu.Items.Add("Miễn phí");
            cmbtendichvu.Items.Add("Hiển thị nỗi bật");
        }

        void LoadBDS()
        {
            cmbloaibds.Items.Add("Căn Hộ");
            cmbloaibds.Items.Add("Đất");
            cmbloaibds.Items.Add("Kho Xưởng");
            cmbloaibds.Items.Add("Mặt Bằng");
            cmbloaibds.Items.Add("Nhà");
        }

        void Loadquanbytentinh(string tentinh)
        {
            string sql = "select * from Quan where tentinh = N'"+ tentinh +"'";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            List<string> listquan = new List<string>();
            foreach (DataRow item in data.Rows)
            {
                string temp;
                temp = item["tenquan"].ToString();
                listquan.Add(temp);
            }

            cmbquan.DataSource = listquan;
        }

        void Loadduongbytenquan(string tenquan, string tentinh)
        {
            string sql = "select * from Duong where tentinh = N'" + tentinh + "' and tenquan = N'"+ tenquan +"'";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            List<string> listduong = new List<string>();
            foreach (DataRow item in data.Rows)
            {
                string temp;
                temp = item["tenduong"].ToString();
                listduong.Add(temp);
            }

            cmbduong.DataSource = listduong;
        }
        void Loadsonhabytenduong(string tenduong, string tenquan, string tentinh)
        {
            string sql = "select * from Sonha where tentinh = N'" + tentinh + "' and tenquan = N'" + tenquan + "' and tenduong = N'"+ tenduong +"'";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            List<int> listsonha = new List<int>();
            foreach (DataRow item in data.Rows)
            {
                int temp;
                temp = (int)item["sonha"];
                listsonha.Add(temp);
            }
            
            cmbsonha.DataSource = listsonha;
        }

        void Loadloaitin()
        {
            cmbloaitin.Items.Add("Bán");
            cmbloaitin.Items.Add("Cho Thuê");
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbloaitin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbloaibds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tentinh;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            tentinh = cb.SelectedItem as string;
            Loadquanbytentinh(tentinh);
        }

        private void cmbquan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenquan;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            tenquan = cb.SelectedItem as string;

            string tentinh;
            tentinh = cmbtinh.Text;
            Loadduongbytenquan(tenquan, tentinh);
        }

        private void cmbduong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenduong;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            tenduong = cb.SelectedItem as string;

            string tentinh, tenquan;
            tentinh = cmbtinh.Text;
            tenquan = cmbquan.Text;
            Loadsonhabytenduong(tenduong, tenquan, tentinh);
        }

        private void btntinhphi_Click(object sender, EventArgs e)
        {
         
        }

        private void btndang_Click(object sender, EventArgs e)
        {
            try
            {
                string tieude = txttieude.Text;
                string loaitin = cmbloaitin.Text;
                string tenbds = txttenbds.Text;
                string loaibds = cmbloaibds.Text;
                string mota = txtmota.Text;
                string sdt = txtsdt.Text;
                string email = txtemail.Text;
                string dientich = txtdientich.Text;
                string gia = txtgia.Text;
                string sophong = txtsophong.Text;
                string block = txtblock.Text;
                string tentinh = cmbtinh.Text;
                string tenquan = cmbquan.Text;
                string tenduong = cmbduong.Text;
                string sonha = cmbsonha.Text;
                string tendv = cmbtendichvu.Text;

                Random x = new Random();
                int idtin = x.Next(100, 10000);
                float giabds = (float)Convert.ToDouble(gia);
                int dientichbds = (int)Convert.ToInt32(dientich);
                int sophongbds = (int)Convert.ToInt32(sophong);

                string sql = @"usp_inserttindang @tieude = N'" + tieude + "' , @loaitin = N'" + loaitin + "' , @username = '" + Username + "', @tenbds = N'" + tenbds + "' , @loaibds = N'" + loaibds + "' , @mota = N'" + mota + "' , @gia = " + giabds + " , @dientich = " + dientichbds + " , @sdt = '" + sdt + "' , @email = '" + email + "' , @sophong = " + sophongbds + " , @block = '" + block + "' , @maduan = 1 , @tentinh = N'" + tentinh + "' , @tenquan = N'" + tenquan + "' , @tenduong = N'" + tenduong + "', @sonha = " + sonha + ", @tendichvu = N'" + tendv + "'";

                Dataprovider.Instance.ExcuteNonQuery(sql);
                MessageBox.Show("Đăng thành công!");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbtendichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbtendichvu_DisplayMemberChanged(object sender, EventArgs e)
        {
        }

        private void cmbtendichvu_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void cmbtendichvu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbtendichvu.Text == "Miễn phí")
            {
                txtsongay.Text = "2";
                return;
            }
            if (cmbtendichvu.Text == "Hiển thị nỗi bật")
            {
                txtsongay.Text = "2";
                txtphidichvu.Text = "10000";
                return;
            }
        }
    }
}
