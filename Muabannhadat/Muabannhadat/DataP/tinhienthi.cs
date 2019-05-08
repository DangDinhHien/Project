using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muabannhadat.DataP
{
    public class tinhienthi
    {
        
        private string tieude;

        private float gia;

        private string tentinh;
        private string tenquan;
        private string tenduong;
        private string loaitin;
        private DateTime ngaydang;
        private string mota;
        private int dientich;
        private string sdt;
        private string email;
        private int sonha;

        public int Sonha
        {
            get { return sonha; }
            set { sonha = value; }
        }

        public tinhienthi(string tieude, string loaitin, DateTime ngaydang, string mota, float gia, int dientich, string sdt, string email, string tentinh, string tenquan, string tenduong, int sonha)
        {
            this.Tieude = tieude;
            this.Gia = gia;
            this.Tentinh = tentinh;
            this.Tenquan = tenquan;
            this.Tenduong = tenduong;
            this.Loaitin = loaitin; this.Ngaydang = ngaydang; this.Mota = mota; this.Dientich = dientich; this.Sdt = sdt;
            this.Email = email; this.Sonha = sonha;
        }

        public tinhienthi(DataRow row, int i)
        {
            this.Tieude = row["ten"].ToString();
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
            this.Tentinh = row["tentinh"].ToString();
            this.Tenquan = row["tenquan"].ToString();
            this.Tenduong = row["tenduong"].ToString();
            this.Loaitin = row["loaitin"].ToString();
            this.Ngaydang = (DateTime)row["ngaydang"]; 
            this.Mota = row["mota"].ToString(); 
            this.Dientich = (int)Convert.ToInt32(row["dientich"].ToString()); 
            this.Sdt = row["sdt"].ToString();
            this.Email = row["email"].ToString(); 
            this.Sonha = (int)Convert.ToInt32(row["sonha"].ToString());
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public int Dientich
        {
            get { return dientich; }
            set { dientich = value; }
        }

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        public DateTime Ngaydang
        {
            get { return ngaydang; }
            set { ngaydang = value; }
        }

        public string Loaitin
        {
            get { return loaitin; }
            set { loaitin = value; }
        }

        public tinhienthi(string tieude, float gia, string tentinh, string tenquan, string tenduong)
        {
            this.Tieude = tieude;
            this.Gia = gia;
            this.Tentinh = tentinh;
            this.Tenquan = tenquan;
            this.Tenduong = tenduong;
        }

        public tinhienthi(DataRow row)
        {
            this.Tieude = row["ten"].ToString();
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
            this.Tentinh = row["tentinh"].ToString();
            this.Tenquan = row["tenquan"].ToString();
            this.Tenduong = row["tenduong"].ToString();
        }

        public string Tenduong
        {
            get { return tenduong; }
            set { tenduong = value; }
        }

        public string Tenquan
        {
            get { return tenquan; }
            set { tenquan = value; }
        }

        public string Tentinh
        {
            get { return tentinh; }
            set { tentinh = value; }
        }

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public string Tieude
        {
            get { return tieude; }
            set { tieude = value; }
        }
    }
}
