using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_QuanLySinhVienKhoaCNTT
{
    public partial class frmSinhVienKhoaCNTT : Form
    {
        private ArrayList dsSinhVien = new ArrayList();
        private bool isModified = false;
        private const string DataFile = "DSNV.txt";

        public frmSinhVienKhoaCNTT()
        {
            InitializeComponent();
        }

        private void frmSinhVienKhoaCNTT_Load(object sender, EventArgs e)
        {
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;

            DocTuFile(DataFile);
            HienThiListView();
            isModified = false;
        }

        public void DocTuFile(string filename)
        {
            dsSinhVien.Clear();
            if (!File.Exists(filename))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read), Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] s = line.Split('\t');
                        if (s.Length < 9)
                        {
                            s = line.Split(',');
                        }

                        if (s.Length >= 9)
                        {
                            SinhVien sv = new SinhVien();
                            sv.MSSV = s[0].Trim();
                            sv.HoTen = s[1].Trim();

                            string gt = s[2].Trim();
                            sv.GioiTinh = (gt == "1" || string.Equals(gt, "Nam", StringComparison.OrdinalIgnoreCase));

                            DateTime dt;
                            if (DateTime.TryParseExact(s[3].Trim(), new string[] { "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "MM/dd/yyyy" },
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                            {
                                sv.NgaySinh = dt;
                            }
                            else if (DateTime.TryParse(s[3].Trim(), out dt))
                            {
                                sv.NgaySinh = dt;
                            }
                            else
                            {
                                sv.NgaySinh = DateTime.Now;
                            }

                            sv.Lop = s[4].Trim();
                            sv.SoDT = s[5].Trim();
                            sv.Email = s[6].Trim();
                            sv.DiaChi = s[7].Trim();
                            sv.Hinh = s[8].Trim();

                            dsSinhVien.Add(sv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GhiVaoFile(string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                {
                    foreach (SinhVien sv in dsSinhVien)
                    {
                        sw.WriteLine(sv.ToString());
                    }
                }
                isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in dsSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoDT);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Hinh);
                item.Tag = sv;
                this.lvSinhVien.Items.Add(item);
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = item.Tag as SinhVien;
                if (sv != null)
                {
                    ThietLapThongTin(sv);
                }
            }
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.mtxtSoDT.Text = sv.SoDT;
            this.txtHinh.Text = sv.Hinh;

            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            try
            {
                if (!string.IsNullOrWhiteSpace(sv.Hinh) && File.Exists(sv.Hinh))
                {
                    this.pbHinh.ImageLocation = sv.Hinh;
                }
                else
                {
                    this.pbHinh.ImageLocation = "";
                }
            }
            catch
            {
                this.pbHinh.ImageLocation = "";
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn hình sinh viên";
                dlg.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All Files(*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.txtHinh.Text = dlg.FileName;
                    this.pbHinh.ImageLocation = dlg.FileName;
                }
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Clear();
            this.txtHoTen.Clear();
            this.txtEmail.Clear();
            this.txtDiaChi.Clear();
            this.txtHinh.Clear();
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.mtxtSoDT.Clear();
            if (this.cboLop.Items.Count > 0)
                this.cboLop.SelectedIndex = 0;
            this.mtxtMSSV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = this.mtxtMSSV.Text.Trim();
            if (mssv.Length != 7)
            {
                MessageBox.Show("Mã sinh viên phải gồm 7 ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.mtxtMSSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHoTen.Focus();
                return;
            }

            // Tìm kiếm sinh viên theo mã số trong danh sách ArrayList
            SinhVien existing = null;
            foreach (SinhVien item in dsSinhVien)
            {
                if (string.Equals(item.MSSV.Trim(), mssv, StringComparison.OrdinalIgnoreCase))
                {
                    existing = item;
                    break;
                }
            }

            if (existing != null)
            {
                // Cập nhật thông tin sinh viên
                existing.HoTen = this.txtHoTen.Text.Trim();
                existing.GioiTinh = this.rdNam.Checked;
                existing.NgaySinh = this.dtpNgaySinh.Value;
                existing.Lop = this.cboLop.Text.Trim();
                existing.SoDT = this.mtxtSoDT.Text.Trim();
                existing.Email = this.txtEmail.Text.Trim();
                existing.DiaChi = this.txtDiaChi.Text.Trim();
                existing.Hinh = this.txtHinh.Text.Trim();

                isModified = true;
                HienThiListView();
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm sinh viên mới
                SinhVien svMoi = new SinhVien
                {
                    MSSV = mssv,
                    HoTen = this.txtHoTen.Text.Trim(),
                    GioiTinh = this.rdNam.Checked,
                    NgaySinh = this.dtpNgaySinh.Value,
                    Lop = this.cboLop.Text.Trim(),
                    SoDT = this.mtxtSoDT.Text.Trim(),
                    Email = this.txtEmail.Text.Trim(),
                    DiaChi = this.txtDiaChi.Text.Trim(),
                    Hinh = this.txtHinh.Text.Trim()
                };

                dsSinhVien.Add(svMoi);
                isModified = true;
                HienThiListView();
                MessageBox.Show("Thêm sinh viên mới vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa {this.lvSinhVien.SelectedItems.Count} sinh viên đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var selectedSV = new List<SinhVien>();
                foreach (ListViewItem item in this.lvSinhVien.SelectedItems)
                {
                    SinhVien sv = item.Tag as SinhVien;
                    if (sv != null)
                    {
                        selectedSV.Add(sv);
                    }
                }

                foreach (SinhVien sv in selectedSV)
                {
                    dsSinhVien.Remove(sv);
                }

                isModified = true;
                HienThiListView();
                btnMacDinh.PerformClick();
            }
        }

        private void tsmiTaiLai_Click(object sender, EventArgs e)
        {
            DocTuFile(DataFile);
            HienThiListView();
            isModified = false;
            btnMacDinh.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienKhoaCNTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult dr = MessageBox.Show("Danh sách sinh viên đã có sự thay đổi. Bạn có muốn lưu vào tập tin DSNV.txt không?", "Xác nhận lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    GhiVaoFile(DataFile);
                }
            }
        }
    }
}
