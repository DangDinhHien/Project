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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Dangnhap(string username, string password)
        {
            string sql = "usp_login @username , @password";
            DataTable ketqua = Dataprovider.Instance.ExcuteQuery(sql, new object[] { username, password });
            return ketqua.Rows.Count > 0;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (Dangnhap(username, password))
            {
                Trangchu f = new Trangchu(username);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            
        }
    }
}
