using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3_Chu_de_2
{
    public partial class frmTBGiangVien : Form
    {
        public frmTBGiangVien()
        {
            InitializeComponent();
        }
        // Gán chuỗi s cho thuộc tính text của lblThongBao
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }

    }
}
