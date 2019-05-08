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
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
        }

        private void Timkiem_Load(object sender, EventArgs e)
        {
            Loaddulieu();
        }

        void Loaddulieu()
        {
            List<tinhienthi> tablelist = Loadlistdulieu();

            dgvtin.DataSource = tablelist;
        }

        public List<tinhienthi> Loadlistdulieu()
        {
            List<tinhienthi> listtin = new List<tinhienthi>();

            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from Tindang a, BDS b where a.id = b.matin");

            foreach (DataRow item in data.Rows)
            {
                tinhienthi tb = new tinhienthi(item, 1);
                listtin.Add(tb);
            }

            return listtin;
        }
        public List<tinhienthi> Loadlistdulieutimkiem(string noidung)
        {
            List<tinhienthi> listtin = new List<tinhienthi>();

            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from Tindang a, BDS b where a.id = b.matin and a.ten like N'%"+noidung+"%'");

            foreach (DataRow item in data.Rows)
            {
                tinhienthi tb = new tinhienthi(item, 1);
                listtin.Add(tb);
            }

            return listtin;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            string noidung = txtnoidung.Text;
            List<tinhienthi> list = Loadlistdulieutimkiem(noidung);
            dgvtin.DataSource = list;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
