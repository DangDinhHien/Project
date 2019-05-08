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
    public partial class Thongtincanhan : Form
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public Thongtincanhan(string a)
        {
            Username = a;
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Thongtincanhan_Load(object sender, EventArgs e)
        {
            Loadthongtinbyusername(Username);
        }

        void Loadthongtinbyusername(string username)
        {
            string sql = "select * from Taikhoan where username = '" + username + "'";
            DataTable data = Dataprovider.Instance.ExcuteQuery(sql);
            DataRow row = data.Rows[0];
            txtten.Text = row["ten"].ToString();
            txtusername.Text = row["username"].ToString();
            txtgioitinh.Text = row["gioitinh"].ToString();
            txtemail.Text = row["email"].ToString();
            txttencongty.Text = row["tenct"].ToString();
            txtsdt.Text = row["sdt"].ToString();
            txtdiachi.Text = row["sonha"].ToString() + " " + row["tenduong"].ToString() + ", " + row["tenquan"].ToString() + ", " + row["tentinh"].ToString() ;
        }

     

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtten.Text;
                string tenct = txttencongty.Text;
                string gioitinh = txtgioitinh.Text;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;

                string sql = @"exec usp_capnhattaikhoan @username , @ten , @tenct , @gioitinh , @email , @sdt";
                int ketqua = Dataprovider.Instance.ExcuteNonQuery(sql, new object[] { Username, ten, tenct, gioitinh, email, sdt });

                if (ketqua > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
               
        }
    }
}
