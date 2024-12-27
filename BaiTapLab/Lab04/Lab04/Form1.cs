using System.Collections;

namespace Lab04
{
    public partial class frmQuanLySinhVien : Form
    {
        private ArrayList DSSV = new ArrayList(); // Danh sách sinh viên
        private bool isDataModified = false;     // Biến kiểm tra danh sách có bị chỉnh sửa hay không

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        // Sự kiện nút "Chọn hình"
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*",
                Title = "Chọn hình ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialog.FileName; // Ghi đường dẫn vào textbox
                pbHinh.Image = Image.FromFile(openFileDialog.FileName); // Hiển thị hình ảnh trong PictureBox
            }
        }

        // Sự kiện nút "Mặc định"
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            mtxtMSSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHinh.Text = string.Empty;
            pbHinh.Image = null;
            mtxtSoDienThoai.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            rdNam.Checked = true; // Mặc định giới tính là Nam
            cboLop.SelectedIndex = -1; // Không chọn lớp nào
        }

        // Sự kiện nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện nút "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = mtxtMSSV.Text.Trim();
            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien? existingSV = null;

            // Kiểm tra sinh viên theo MSSV
            foreach (SinhVien sv in DSSV)
            {
                if (sv.MSSV == mssv)
                {
                    existingSV = sv;
                    break;
                }
            }

            // Nếu sinh viên đã tồn tại, cập nhật thông tin
            if (existingSV != null)
            {
                existingSV.HoVaTen = txtHoTen.Text.Trim();
                existingSV.Phai = rdNam.Checked ? "Nam" : "Nữ";
                existingSV.NgaySinh = dtpNgaySinh.Value;
                existingSV.Lop = cboLop.SelectedItem?.ToString() ?? ""; // Nếu null, gán chuỗi rỗng
                existingSV.SoDienThoai = mtxtSoDienThoai.Text.Trim();
                existingSV.Email = txtEmail.Text.Trim();
                existingSV.DiaChi = txtDiaChi.Text.Trim();
                existingSV.Hinh = txtHinh.Text.Trim();
            }
            else // Nếu không tìm thấy, thêm mới
            {
                SinhVien newSV = new SinhVien
                {
                    MSSV = mssv,
                    HoVaTen = txtHoTen.Text.Trim(),
                    Phai = rdNam.Checked ? "Nam" : "Nữ",
                    NgaySinh = dtpNgaySinh.Value,
                    Lop = cboLop.SelectedItem?.ToString() ?? "", // Nếu null, gán chuỗi rỗng
                    SoDienThoai = mtxtSoDienThoai.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    Hinh = txtHinh.Text.Trim()
                };
                DSSV.Add(newSV);
            }

            HienThiDSSV(); // Hiển thị danh sách sinh viên
        }

        // Hiển thị danh sách sinh viên trong ListView
        private void HienThiDSSV()
        {
            lvSinhVien.Items.Clear(); // Xóa toàn bộ danh sách cũ
            foreach (SinhVien sv in DSSV)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoVaTen);
                item.SubItems.Add(sv.Phai);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoDienThoai);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Hinh);
                lvSinhVien.Items.Add(item);
            }
        }

        // Sự kiện chọn sinh viên trong ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                mtxtMSSV.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                rdNam.Checked = item.SubItems[2].Text == "Nam";
                rdNu.Checked = item.SubItems[2].Text == "Nữ";
                dtpNgaySinh.Value = DateTime.Parse(item.SubItems[3].Text);
                cboLop.SelectedItem = item.SubItems[4].Text;
                mtxtSoDienThoai.Text = item.SubItems[5].Text;
                txtEmail.Text = item.SubItems[6].Text;
                txtDiaChi.Text = item.SubItems[7].Text;
                txtHinh.Text = item.SubItems[8].Text;
                pbHinh.Image = string.IsNullOrEmpty(item.SubItems[8].Text) ? null : Image.FromFile(item.SubItems[8].Text);
            }
        }

        // Sự kiện xóa sinh viên bằng context menu
        private void contextMenuXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvSinhVien.SelectedItems)
            {
                string mssv = selectedItem.Text;

                // Xóa sinh viên trong danh sách DSSV
                DSSV.Remove(DSSV.Cast<SinhVien>().FirstOrDefault(sv => sv.MSSV == mssv));

                // Xóa sinh viên trong ListView
                lvSinhVien.Items.Remove(selectedItem);
            }
        }

        // Sự kiện Form_Load: Tải danh sách từ DSNV.txt
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachTuFile();
        }

        // Sự kiện chuột phải: Tải lại danh sách từ DSNV.txt
        private void contextMenuTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tải lại danh sách sinh viên? Các thay đổi chưa lưu sẽ bị mất!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TaiDanhSachTuFile();
            }
        }

        // Sự kiện Form_Closing: Kiểm tra và lưu dữ liệu nếu cần
        private void frmQuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataModified)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu danh sách đã thay đổi không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    LuuDanhSachVaoFile();
                }
            }
        }

        // Hàm tải danh sách sinh viên từ DSSV.txt
        private void TaiDanhSachTuFile()
        {
            try
            {
                DSSV.Clear();
                lvSinhVien.Items.Clear();

                if (File.Exists("DSSV.txt"))
                {
                    string[] lines = File.ReadAllLines("DSSV.txt");
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 9)
                        {
                            SinhVien sv = new SinhVien
                            {
                                MSSV = parts[0],
                                HoVaTen = parts[1],
                                Phai = parts[2],
                                NgaySinh = DateTime.Parse(parts[3]),
                                Lop = parts[4],
                                SoDienThoai = parts[5],
                                Email = parts[6],
                                DiaChi = parts[7],
                                Hinh = parts[8]
                            };
                            DSSV.Add(sv);
                        }
                    }
                }
                HienThiDSSV();
                isDataModified = false; // Đánh dấu dữ liệu không thay đổi sau khi tải
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm lưu danh sách sinh viên vào DSNV.txt
        private void LuuDanhSachVaoFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("DSSV.txt"))
                {
                    foreach (SinhVien sv in DSSV)
                    {
                        string line = $"{sv.MSSV}|{sv.HoVaTen}|{sv.Phai}|{sv.NgaySinh:dd/MM/yyyy}|{sv.Lop}|{sv.SoDienThoai}|{sv.Email}|{sv.DiaChi}|{sv.Hinh}";
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Lưu danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isDataModified = false; // Đánh dấu dữ liệu đã được lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu danh sách sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
