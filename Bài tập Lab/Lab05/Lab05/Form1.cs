using System.Text.RegularExpressions;

namespace Lab05
{
    public partial class frmSinhVien : Form
    {
        private QLSinhVien qlSinhVien;
        private string filePathTXT = "students.txt";
        private string filePathXML = "students.xml";
        private string filePathJSON = "students.json";

        public frmSinhVien()
        {
            InitializeComponent();
            qlSinhVien = new QLSinhVien();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // Tải danh sách sinh viên từ file TXT
            if (File.Exists(filePathTXT))
            {
                qlSinhVien.DocTuFileTXT(filePathTXT);
                CapNhatListView();
            }

            // Tải danh sách sinh viên từ file XML
            if (File.Exists(filePathXML))
            {
                qlSinhVien.DocTuFileXML(filePathXML);
                CapNhatListView();
            }

            // Tải danh sách sinh viên từ file JSON
            if (File.Exists(filePathJSON))
            {
                qlSinhVien.DocTuFileJSON(filePathJSON);
                CapNhatListView();
            }

            // Thêm ContextMenu vào Môn học và ListView
            TaoContextMenu();
        }

        // Cập nhật dữ liệu từ danh sách sinh viên vào ListView
        private void CapNhatListView()
        {
            lvDanhSachSinhVien.Items.Clear();
            foreach (var sv in qlSinhVien.DanhSachSinhVien)
            {
                var item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoVaTenLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.CMND);
                item.SubItems.Add(sv.SoDienThoai);
                item.SubItems.Add(sv.DiaChiLienLac);
                lvDanhSachSinhVien.Items.Add(item);
            }
        }

        // Sự kiện chọn một sinh viên trong danh sách
        private void lvDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSinhVien.SelectedItems.Count > 0)
            {
                var item = lvDanhSachSinhVien.SelectedItems[0];
                var sv = qlSinhVien.DanhSachSinhVien.FirstOrDefault(s => s.MSSV == item.Text);
                if (sv != null)
                {
                    mtxtMSSV.Text = sv.MSSV;
                    txtHoVaTenLot.Text = sv.HoVaTenLot;
                    txtTen.Text = sv.Ten;
                    dtpNgaySinh.Value = sv.NgaySinh;
                    cboLop.Text = sv.Lop;
                    txtCMND.Text = sv.CMND;
                    mtxtSoDienThoai.Text = sv.SoDienThoai;
                    txtDiaChi.Text = sv.DiaChiLienLac;
                    rdNam.Checked = sv.GioiTinh;
                    rdNu.Checked = !sv.GioiTinh;
                }
            }
        }

        // Thêm sinh viên
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mssv = TaoMSSV(cboLop.Text); // Tự động tạo MSSV
            var sv = new SinhVien
            {
                MSSV = mssv,
                HoVaTenLot = txtHoVaTenLot.Text,
                Ten = txtTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                Lop = cboLop.Text,
                CMND = txtCMND.Text,
                SoDienThoai = mtxtSoDienThoai.Text,
                DiaChiLienLac = txtDiaChi.Text,
                GioiTinh = rdNam.Checked,
                MonHocDangKy = LayMonHocDangKy()
            };

            qlSinhVien.ThemSinhVien(sv, filePathTXT);
            qlSinhVien.ThemSinhVien(sv, filePathXML);
            qlSinhVien.ThemSinhVien(sv, filePathJSON);
            CapNhatListView();
            MessageBox.Show($"Thêm sinh viên thành công! MSSV: {mssv}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cập nhật sinh viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sv = new SinhVien
            {
                MSSV = mtxtMSSV.Text,
                HoVaTenLot = txtHoVaTenLot.Text,
                Ten = txtTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                Lop = cboLop.Text,
                CMND = txtCMND.Text,
                SoDienThoai = mtxtSoDienThoai.Text,
                DiaChiLienLac = txtDiaChi.Text,
                GioiTinh = rdNam.Checked,
                MonHocDangKy = LayMonHocDangKy() // Hàm lấy danh sách môn học đăng ký
            };

            qlSinhVien.CapNhatSinhVien(sv, filePathTXT);
            qlSinhVien.CapNhatSinhVien(sv, filePathXML);
            qlSinhVien.CapNhatSinhVien(sv, filePathJSON);
            CapNhatListView();
            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Kiểm tra đầu vào
        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(mtxtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoVaTenLot.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(cboLop.Text) ||
                string.IsNullOrWhiteSpace(txtCMND.Text) ||
                string.IsNullOrWhiteSpace(mtxtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                return false;
            }

            if (!Regex.IsMatch(mtxtMSSV.Text, @"^\d{7}$"))
            {
                MessageBox.Show("MSSV phải có đúng 7 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtCMND.Text, @"^\d{9}$"))
            {
                MessageBox.Show("Số CMND phải có đúng 9 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(mtxtSoDienThoai.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Lấy danh sách môn học đăng ký
        private List<string> LayMonHocDangKy()
        {
            var monHoc = new List<string>();
            foreach (var item in clbMonHocDangKy.Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    monHoc.Add(item.Text);
                }
            }
            return monHoc;
        }

        // Xử lý ContextMenu cho Môn học và ListView
        private void TaoContextMenu()
        {
            // ContextMenu cho Môn học
            var contextMenuMonHoc = new ContextMenuStrip();
            contextMenuMonHoc.Items.Add("Thêm môn học", null, (s, e) => MessageBox.Show("Chức năng thêm môn học."));
            contextMenuMonHoc.Items.Add("Xóa môn học", null, (s, e) => MessageBox.Show("Chức năng xóa môn học."));
            clbMonHocDangKy.ContextMenuStrip = contextMenuMonHoc;

            // ContextMenu cho ListView
            var contextMenuListView = new ContextMenuStrip();
            contextMenuListView.Items.Add("Xóa sinh viên", null, (s, e) =>
            {
                foreach (ListViewItem item in lvDanhSachSinhVien.CheckedItems)
                {
                    qlSinhVien.XoaSinhVien(new List<string> { item.Text }, filePathTXT);
                    qlSinhVien.XoaSinhVien(new List<string> { item.Text }, filePathXML);
                    qlSinhVien.XoaSinhVien(new List<string> { item.Text }, filePathJSON);
                }
                CapNhatListView();
            });
            lvDanhSachSinhVien.ContextMenuStrip = contextMenuListView;
        }

        // Sự kiện Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiem timKiemForm = new FormTimKiem(qlSinhVien);
            if (timKiemForm.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị kết quả tìm kiếm trên ListView
                var ketQua = timKiemForm.KetQuaTimKiem;
                lvDanhSachSinhVien.Items.Clear();
                foreach (var sv in ketQua)
                {
                    var item = new ListViewItem(sv.MSSV);
                    item.SubItems.Add(sv.HoVaTenLot);
                    item.SubItems.Add(sv.Ten);
                    item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                    item.SubItems.Add(sv.Lop);
                    item.SubItems.Add(sv.CMND);
                    item.SubItems.Add(sv.SoDienThoai);
                    item.SubItems.Add(sv.DiaChiLienLac);
                    lvDanhSachSinhVien.Items.Add(item);
                }
            }
        }

        // Sự kiện Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Hàm tạo MSSV
        private string TaoMSSV(string lop)
        {
            // Xác định năm nhập học từ lớp
            string namNhapHoc = lop.Substring(3, 2); // CTK45 → 45 (năm nhập học là 20 + 45 = 2045)
            string bb = "10"; // BB cố định
            string ccc;

            // Tìm số lớn nhất hiện tại trong MSSV và tăng lên 1
            int maxCcc = qlSinhVien.DanhSachSinhVien
                .Where(sv => sv.MSSV.StartsWith(namNhapHoc + bb))
                .Select(sv => int.Parse(sv.MSSV.Substring(4, 3)))
                .DefaultIfEmpty(0)
                .Max();

            ccc = (maxCcc + 1).ToString("D3"); // CCC luôn có 3 chữ số, ví dụ 001, 002

            return namNhapHoc + bb + ccc;
        }
    }
}
