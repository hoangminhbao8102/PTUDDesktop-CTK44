using System.Diagnostics;

namespace Lab2_BaiTap
{
    public partial class frmGiaoVien : Form
    {
        private QuanLyGiaoVien quanLyGiaoVien = new QuanLyGiaoVien();

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                var selectedItem = lbDanhSachMH.SelectedItems[i]; // Lấy item hiện tại

                if (selectedItem != null) // Đảm bảo item không null
                {
                    this.lbMonHocDay.Items.Add(selectedItem); // Thêm vào danh sách MonHocDay
                    this.lbDanhSachMH.Items.Remove(selectedItem); // Xóa khỏi danh sách DanhSachMH
                }

                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                var selectedItem = lbMonHocDay.SelectedItems[i]; // Lấy item hiện tại

                if (selectedItem != null) // Kiểm tra item không null
                {
                    this.lbDanhSachMH.Items.Add(selectedItem); // Thêm vào danh sách DanhSachMH
                    this.lbMonHocDay.Items.Remove(selectedItem); // Xóa khỏi danh sách MonHocDay
                }

                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            //Bỏ chọn trên chklbNgoaiNgu
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }
            //Chuyển các môn từ lbMonHocDay sang lbDanhSachMH
            foreach (object ob in this.lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            this.lbMonHocDay.Items.Clear();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Sử dụng null-conditional để tránh tham chiếu null
            string? linkData = e.Link?.LinkData?.ToString();

            if (!string.IsNullOrEmpty(linkData)) // Kiểm tra linkData có hợp lệ
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkData,
                    UseShellExecute = true // Bắt buộc trong các phiên bản .NET hiện đại
                });
            }
            else
            {
                MessageBox.Show("Liên kết không khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
            {
                gt = "Nữ";
            }

            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text ?? string.Empty; // Đảm bảo giá trị không null
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text ?? string.Empty;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text ?? string.Empty;
            gv.SoDT = this.mtxtSoDT.Text ?? string.Empty;

            // Lấy thông tin ngọai ngữ
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++) // Điều chỉnh để không bỏ qua phần tử cuối
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                {
                    ngoaingu += chklbNgoaiNgu.Items[i]?.ToString() + ";"; // Kiểm tra null
                }
            }
            gv.NgoaiNgu = ngoaingu.Split(';', StringSplitOptions.RemoveEmptyEntries);

            // Lấy thông tin danh sách môn học
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
            {
                if (ob != null) // Kiểm tra null trước khi sử dụng
                {
                    mh.Them(new MonHoc(ob.ToString() ?? string.Empty)); // Đảm bảo giá trị không null
                }
            }
            gv.dsMonHoc = mh;

            return gv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSo = cboMaSo.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string mail = txtMail.Text.Trim();
            string soDT = mtxtSoDT.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;

            // Lấy ngoại ngữ
            List<string> ngoaiNgu = new List<string>();
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                {
                    var item = chklbNgoaiNgu.Items[i]?.ToString(); // Kiểm tra null trước
                    if (!string.IsNullOrEmpty(item))
                    {
                        ngoaiNgu.Add(item);
                    }
                }
            }

            // Lấy danh sách môn học
            DanhMucMonHoc dsMonHoc = new DanhMucMonHoc();
            foreach (object item in lbMonHocDay.Items)
            {
                var tenMonHoc = item?.ToString(); // Kiểm tra null trước
                if (!string.IsNullOrEmpty(tenMonHoc))
                {
                    dsMonHoc.Them(new MonHoc(tenMonHoc));
                }
            }

            // Tạo đối tượng giáo viên
            GiaoVien gvMoi = new GiaoVien
            {
                MaSo = maSo,
                HoTen = hoTen,
                GioiTinh = gioiTinh,
                NgaySinh = ngaySinh,
                Mail = mail,
                SoDT = soDT,
                NgoaiNgu = ngoaiNgu.ToArray(),
                dsMonHoc = dsMonHoc
            };

            // Sử dụng delegate SoSanh để tìm kiếm
            SoSanh ss = SoSanhTheoMa;
            if (quanLyGiaoVien.Tim(maSo, ss) != null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quanLyGiaoVien.Them(gvMoi);
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Hàm so sánh theo mã số (khớp với kiểu delegate SoSanh)
        private int SoSanhTheoMa(object a, object b)
        {
            GiaoVien? gv = b as GiaoVien;
            if (gv != null && a is string maSo)
            {
                // Sử dụng ?? để đảm bảo gv.MaSo không null
                return string.Compare(maSo, gv.MaSo ?? string.Empty, StringComparison.OrdinalIgnoreCase);
            }
            return -1; // Không khớp
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng FrmTimThongTin
            frmTimThongTin frmTim = new frmTimThongTin();

            // Hiển thị form tìm thông tin
            frmTim.ShowDialog();
        }
    }
}
