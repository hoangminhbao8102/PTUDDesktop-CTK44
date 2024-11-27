using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class FormTimKiem : Form
    {
        private QLSinhVien qlSinhVien; // Tham chiếu đến danh sách sinh viên
        public List<SinhVien> KetQuaTimKiem { get; private set; } // Lưu kết quả tìm kiếm

        public string MSSV => mtxtMSSV.Text.Trim(); // Dành cho tìm kiếm nâng cao - MSSV
        public string Ten => txtTen.Text.Trim();   // Dành cho tìm kiếm nâng cao - Tên
        public string Lop => cboLop.Text.Trim();   // Dành cho tìm kiếm nâng cao - Lớp

        public FormTimKiem(QLSinhVien qlSinhVien)
        {
            InitializeComponent();
            this.qlSinhVien = qlSinhVien;
            KetQuaTimKiem = new List<SinhVien>();
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox tìm kiếm cơ bản
            cboTimKiem.SelectedIndex = 0; // Chọn MSSV mặc định

            // Mặc định chọn tìm kiếm cơ bản
            rdCoBan.Checked = true;
            CapNhatCheDoTimKiem();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdCoBan.Checked)
            {
                TimKiemTheoCoBan();
            }
            else if (rdNangCao.Checked)
            {
                TimKiemTheoNangCao();
            }
        }

        // Tìm kiếm cơ bản theo ComboBox
        private void TimKiemTheoCoBan()
        {
            string timKiem = txtTimKiem.Text?.Trim() ?? string.Empty; // Kiểm tra null
            if (string.IsNullOrWhiteSpace(timKiem))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc danh sách sinh viên theo loại tìm kiếm
            string loaiTimKiem = cboTimKiem.SelectedItem?.ToString() ?? string.Empty; // Kiểm tra null
            KetQuaTimKiem = new List<SinhVien>(); // Khởi tạo danh sách rỗng để tránh null

            switch (loaiTimKiem)
            {
                case "MSSV":
                    KetQuaTimKiem = qlSinhVien.DanhSachSinhVien?
                        .Where(sv => sv.MSSV.Contains(timKiem, StringComparison.OrdinalIgnoreCase))
                        .ToList() ?? new List<SinhVien>();
                    break;
                case "Tên":
                    KetQuaTimKiem = qlSinhVien.DanhSachSinhVien?
                        .Where(sv => sv.Ten.Contains(timKiem, StringComparison.OrdinalIgnoreCase))
                        .ToList() ?? new List<SinhVien>();
                    break;
                case "Lớp":
                    KetQuaTimKiem = qlSinhVien.DanhSachSinhVien?
                        .Where(sv => sv.Lop.Contains(timKiem, StringComparison.OrdinalIgnoreCase))
                        .ToList() ?? new List<SinhVien>();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            HienThiKetQua();
        }

        // Tìm kiếm nâng cao theo nhiều điều kiện
        private void TimKiemTheoNangCao()
        {
            string mssv = MSSV;
            string ten = Ten;
            string lop = Lop;

            KetQuaTimKiem = qlSinhVien.DanhSachSinhVien?
                .Where(sv =>
                    (string.IsNullOrWhiteSpace(mssv) || sv.MSSV.Contains(mssv, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrWhiteSpace(ten) || sv.Ten.Contains(ten, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrWhiteSpace(lop) || sv.Lop.Contains(lop, StringComparison.OrdinalIgnoreCase))
                )
                .ToList() ?? new List<SinhVien>();

            HienThiKetQua();
        }

        // Hiển thị kết quả tìm kiếm
        private void HienThiKetQua()
        {
            if (KetQuaTimKiem.Count > 0)
            {
                MessageBox.Show($"Tìm thấy {KetQuaTimKiem.Count} kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Khi thay đổi lựa chọn giữa "Cơ bản" và "Nâng cao"
        private void rdCoBan_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatCheDoTimKiem();
        }

        private void rdNangCao_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatCheDoTimKiem();
        }

        // Cập nhật chế độ tìm kiếm
        private void CapNhatCheDoTimKiem()
        {
            // Nếu chọn "Cơ bản", chỉ bật gboCoBan và tắt gboNangCao
            if (rdCoBan.Checked)
            {
                gboCoBan.Enabled = true;
                gboNangCao.Enabled = false;
            }
            // Nếu chọn "Nâng cao", chỉ bật gboNangCao và tắt gboCoBan
            else if (rdNangCao.Checked)
            {
                gboCoBan.Enabled = false;
                gboNangCao.Enabled = true;
            }
        }
    }
}
