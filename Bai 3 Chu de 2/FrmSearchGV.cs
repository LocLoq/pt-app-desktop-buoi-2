using Bai_3_Chu_de_2.Enum;
using Bai_3_Chu_de_2.Model;
using Bai_3_Chu_de_2.Singleton;
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
    public partial class FrmSearchGV : Form
    {
        public KieuTim kieuTim { get; set; }
        public FrmSearchGV()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            GiangVien gv = null;
            if (string.IsNullOrEmpty(searchValueTBox.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (kieuTim)
            {
                case KieuTim.TheoMa:
                    gv = DSGiangVienSingleton.Instance.GiangVienList.Find(g => g.MaSo.Equals(searchValueTBox.Text));
                    break;
                case KieuTim.TheoHoTen:
                    gv = DSGiangVienSingleton.Instance.GiangVienList.Find(g => g.HoTen.Equals(searchValueTBox.Text));
                    break;
                case KieuTim.TheoSDT:
                    gv = DSGiangVienSingleton.Instance.GiangVienList.Find(g => g.SoDT.Equals(searchValueTBox.Text));
                    break;
            }
            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var frmTBGV = new frmTBGiangVien();
                frmTBGV.SetText(gv.ToString());
                frmTBGV.ShowDialog();
            }
        }

        private void hoTenRB_CheckedChanged(object sender, EventArgs e)
        {
            findingLabel.Text = hoTenRB.Text;
            kieuTim = KieuTim.TheoHoTen;
        }

        private void sdtRB_CheckedChanged(object sender, EventArgs e)
        {
            findingLabel.Text = sdtRB.Text;
            kieuTim = KieuTim.TheoSDT;
        }

        private void maGVRB_CheckedChanged(object sender, EventArgs e)
        {
            findingLabel.Text = maGVRB.Text;
            kieuTim = KieuTim.TheoMa;
        }
    }
}
