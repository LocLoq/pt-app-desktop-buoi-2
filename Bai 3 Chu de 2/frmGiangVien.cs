using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_3_Chu_de_2.Model;

namespace Bai_3_Chu_de_2
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            //this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
            // mock data for DSGiangVien
            // random danh muc hoc phan for each giang vien
            DanhMucHocPhan dm1 = new DanhMucHocPhan();
            dm1.Them(new HocPhan("Tin học cơ sở"));
            dm1.Them(new HocPhan("Lập trình cấu trúc C/C++"));
            DanhMucHocPhan dm2 = new DanhMucHocPhan();
            dm2.Them(new HocPhan("Tiếng Anh B1"));
            dm2.Them(new HocPhan("Mạng Máy Tính"));



            Program.dSGiangVien.ThemGiangVien(new GiangVien("001", "0123456789", "nguyenvana@gmail.com", "Nguyễn Văn A", new DateTime(1990, 1, 1), dm1, "Nam", new string[] { "Tiếng Anh", "Tiếng Pháp" }));
            cboMaSo.Items.Add("001");
            Program.dSGiangVien.ThemGiangVien(new GiangVien("002", "0123456788", "tranthib@gmail.com", "Trần Thị B", new DateTime(1992, 5, 15), new DanhMucHocPhan(), "Nữ", new string[] { "Tiếng Anh", "Tiếng Nhật" }));
            cboMaSo.Items.Add("002");

        }

        // Sự kiện btnChon_Click xóa học phần được chọn từ danh sách học phần và chuyển sang danh sách học phần dạy
        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(this.lbDanhSachHP.SelectedItems[i]);
                this.lbDanhSachHP.Items.Remove(this.lbDanhSachHP.SelectedItems[i]);
                i--;
            }
        }

        // Sự kiện btnXoa_Click xóa học phần được chọn từ danh sách học phần dạy và chuyển sang danh sách học phần
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(this.lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(this.lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        // Sự kiện btnCancel_Click thiết lập controls về giá trị mặc định
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.lbHocPhanDay.Items)
                this.lbDanhSachHP.Items.Add(ob);
            this.lbHocPhanDay.Items.Clear();
        }

        // Sự kiện btnThongBao_Click lấy thông tin đã nhập trên frmGiangVien, hiển thị thông tin lên frmTBGiangVien
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        // Lấy thông tin của giảng viên được nhập trên form
        public GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiangVien gv = new GiangVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;
            string ngoaiNgu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaiNgu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaiNgu.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
                dshp.Them(new HocPhan(hp.ToString()));
            gv.dsHocPhan = dshp;
            return gv;
        }

        // Sự kiện linklbLienHe_LinkClicked mở website liên hệ https://cntt.dlu.edu.vn/
        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strlink = e.Link.LinkData.ToString();
            Process.Start(strlink);
        }

        // Sự kiện btnExit_Click thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            // check if maso exist
            for (int i = 0; i < Program.dSGiangVien.Count; i++)
            {
                GiangVien gv = Program.dSGiangVien[i];
                if (gv.MaSo == this.cboMaSo.Text)
                {
                    MessageBox.Show("Mã số giảng viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Program.dSGiangVien.ThemGiangVien(GetGiangVien());
            // add to combo box
            this.cboMaSo.Items.Add(this.cboMaSo.Text);
            MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
