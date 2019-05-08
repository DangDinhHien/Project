using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duoi_Hinh_Bat_Chu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] a = new string[15];

        

        private void btnok_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            a[0] = "Cuộc sống chỉ mang đến cho bạn 10% cơ hội, 90% còn lại là cách mà bạn phản ứng với nó. Ráng lên bạn!";
            a[1] = "Để có thể vượt qua câu hỏi, bạn buộc phải tin rằng bạn có thể làm được. Mọi thứ đều ở trong bức ảnh.";
            a[2] = "Không có gì là không thể với một người luôn biết cố gắng. Vì thế bạn hãy cố gắng để vượt qua.";
            a[3] = "Không bao giờ, không bao giờ, không bao giờ từ bỏ. Thua câu này bạn sẽ rút kinh nghiệm được câu khác.";
            a[4] = "Người bi quan thấy khó khăn trong mọi cơ hội. Người lạc quan thấy cơ hội trong mọi khó khăn.";
            a[5] = "Thành công là sự trải qua thất bại này đến thất bại khác mà không mất đi sự nhiệt tình.";
            a[6] = "Cuộc sống giống như việc đi xe đạp, để giữ được thăng bằng thì bạn phải không ngừng chuyển động nó.";
            a[7] = "Chỉ có con đường gập ghềnh chưa từng có người đi vào mới là con đường của thiên tài.";
            a[8] = "Khi mọi thứ đều chống lại bạn thì hãy nhớ rằng máy bay luôn cất cánh ngược chiều gió.";
            a[9] = "Chìa khóa thành công là tập trung lý trí của chúng ta vào những điều chúng ta muốn chứ không phải những điều chúng ta sợ.";
            a[10] = "Không biết đã bao nhiêu lần người ta buông tay từ bỏ khi mà chỉ một chút nỗ lực, một chút kiên trì nữa thôi là ta sẽ đạt được thành công.";
            a[11] = "Thành công không phải là chìa khóa mở cánh cửa hạnh phúc nhưng hạnh phúc lại là chìa khóa dẫn tới cánh cửa thành công. Nếu bạn yêu điều bạn đang làm, bạn sẽ thành công.";
            a[12] = "Vấp ngã 7 lần. Đứng dậy 8 lần.";
            a[13] = "Vết thương là nơi mà ánh sáng sẽ đi xuyên qua.";
            a[14] = "Chỉ khi con sâu bướm nghĩ rằng thế giới của nó kết thúc, nó mới bắt đầu biến thành một con bướm";

            Random r = new Random();
            lbltemp.Text = a[r.Next(0, a.Length)];
        }
    }
}
