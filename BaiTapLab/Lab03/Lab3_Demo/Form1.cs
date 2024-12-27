using System.Collections;

namespace Lab3_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        public frmSinhVien()
        {
            InitializeComponent();
            qlsv = new QuanLySinhVien(); // Khởi tạo ở đây
        }

        #region Phương thức bổ trợ
        //Lấy thông tin từ controls thông tin SV
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();

            // Gán giá trị cho các thuộc tính
            sv.MaSo = this.mtxtMaSo.Text ?? string.Empty; // Xử lý null cho Text
            sv.HoTen = this.txtHoTen.Text ?? string.Empty; // Xử lý null cho Text
            sv.NgaySinh = this.dtpNgaySinh.Value; // DateTime không cần xử lý null
            sv.DiaChi = this.txtDiaChi.Text ?? string.Empty; // Xử lý null cho Text
            sv.Lop = this.cboLop.Text ?? string.Empty; // Xử lý null cho Text
            sv.Hinh = this.txtHinh.Text ?? string.Empty; // Xử lý null cho Text

            // Xác định giới tính
            if (rdNu.Checked)
            {
                gt = false;
            }
            sv.GioiTinh = gt;

            // Duyệt các chuyên ngành
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                {
                    // Xử lý null cho Items[i] trước khi thêm vào danh sách
                    string? item = clbChuyenNganh.Items[i]?.ToString();
                    if (!string.IsNullOrEmpty(item)) // Kiểm tra null hoặc rỗng
                    {
                        cn.Add(item);
                    }
                }
            }
            sv.ChuyenNganh = cn; // Gán danh sách chuyên ngành cho sinh viên
            return sv;
        }

        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
            {
                sv.GioiTinh = true;
            }
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
            {
                cn.Add(t);
            }
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
            {
                this.rdNam.Checked = true;
            }
            else
            {
                this.rdNu.Checked = true;
            }
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                    {
                        this.clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }

        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
            {
                gt = "Nam";
            }
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
            {
                cn += s + ",";
            }
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }

        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }
        #endregion

        #region Các sự kiện
        //Sự kiện Load form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        //Khi chọn dòng sinh viên bên ListView
        //Thực hiện gán thông tin lên các control
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        //Chức năng thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();

            // Tìm sinh viên trong danh sách
            SinhVien? kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                // Kiểm tra null trước khi truy cập obj2
                SinhVien? sinhVien = obj2 as SinhVien;
                if (sinhVien == null)
                {
                    return -1; // Nếu obj2 là null, trả về -1
                }
                return sinhVien.MaSo.CompareTo(obj1.ToString());
            });

            // Kiểm tra kết quả tìm kiếm
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv); // Thêm sinh viên mới vào danh sách
                this.LoadListView(); // Cập nhật giao diện
            }
        }

        //Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Xóa tất cả sinh viên được chọn trên ListView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        //Để các control ở giá trị mặc định
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = string.Empty;
            this.txtHoTen.Text = string.Empty;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = string.Empty;

            // Kiểm tra null cho Items trước khi truy cập phần tử đầu tiên
            if (this.cboLop.Items != null && this.cboLop.Items.Count > 0)
            {
                this.cboLop.Text = this.cboLop.Items[0]?.ToString() ?? string.Empty;
            }
            else
            {
                this.cboLop.Text = string.Empty; // Giá trị mặc định nếu Items rỗng
            }

            this.txtHinh.Text = string.Empty;

            // Kiểm tra null cho pbHinh trước khi gán ImageLocation
            if (this.pbHinh != null)
            {
                this.pbHinh.ImageLocation = string.Empty;
            }

            this.rdNam.Checked = true;

            // Kiểm tra null cho Items trước khi duyệt
            if (this.clbChuyenNganh.Items != null && this.clbChuyenNganh.Items.Count > 0)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                {
                    this.clbChuyenNganh.SetItemChecked(i, false);
                }
            }
        }

        //Sửa thông tin sinh viên được chọn
        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien? sv = obj2 as SinhVien; // Ép kiểu an toàn
            if (sv == null || obj1 == null) // Kiểm tra null trước khi sử dụng
            {
                return -1; // Trả về giá trị mặc định khi obj2 hoặc obj1 là null
            }
            return sv.MaSo.CompareTo(obj1.ToString());
        }
        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để chọn file ảnh
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cấu hình OpenFileDialog
                openFileDialog.Title = "Open File Image";
                openFileDialog.Filter = "Image File|*.bmp;*.jpg;*.png|All Files|*.*";
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // Mặc định là thư mục Debug

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn file được chọn trong TextBox txtHinh
                    this.txtHinh.Text = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox pbHinh
                    this.pbHinh.ImageLocation = openFileDialog.FileName;
                }
            }

            // Cập nhật StatusStrip để hiển thị tổng số sinh viên
            int totalStudents = qlsv.DanhSach.Count; // Giả sử `qlsv.DanhSach` là danh sách sinh viên
            this.statusStripLabel.Text = $"Tổng Sinh Viên: {totalStudents}";
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.bmp;*.jpg;*.png|All Files|*.*",
                Title = "Mở File Hình"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã mở file: " + openFileDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thêm sinh viên vào ListView
            ListViewItem item = new ListViewItem(new string[] { "SV001", "Nguyễn Văn A", "01/01/2000" });
            lvSinhVien.Items.Add(item);
            MessageBox.Show("Đã thêm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa các mục được chọn
            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                lvSinhVien.Items.Remove(item);
            }
            MessageBox.Show("Đã xóa sinh viên được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sửa thông tin sinh viên (ví dụ sửa mục đầu tiên)
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                item.SubItems[1].Text = "Nguyễn Văn B";
                MessageBox.Show("Đã sửa thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.Font = fontDialog.Font;
            }
        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.ForeColor = colorDialog.Color;
            }
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị form frmTuyChon để thực hiện sắp xếp
            frmTuyChon tuyChonForm = new frmTuyChon();
            tuyChonForm.Text = "Sắp Xếp";

            // Đặt chế độ sắp xếp: GroupBox Tìm bị mờ
            tuyChonForm.gboTim.Enabled = false; // Làm mờ GroupBox Tìm
            tuyChonForm.btnSapXep.Enabled = true; // Bật nút Sắp Xếp
            tuyChonForm.btnTim.Enabled = false; // Tắt nút Tìm

            if (tuyChonForm.ShowDialog() == DialogResult.OK)
            {
                // Xác định kiểu sắp xếp dựa trên tùy chọn trong RadioButton
                TuyChon kieuSapXep;

                if (tuyChonForm.rdMaSV.Checked)
                {
                    kieuSapXep = TuyChon.MaSV;
                    MessageBox.Show("Sắp xếp theo Mã SV", "Thông Báo");
                }
                else if (tuyChonForm.rdHoTen.Checked)
                {
                    kieuSapXep = TuyChon.HoTen;
                    MessageBox.Show("Sắp xếp theo Họ Tên", "Thông Báo");
                }
                else if (tuyChonForm.rdNgaySinh.Checked)
                {
                    kieuSapXep = TuyChon.NgaySinh;
                    MessageBox.Show("Sắp xếp theo Ngày Sinh", "Thông Báo");
                }
                else
                {
                    return; // Không có lựa chọn, thoát
                }

                // Thực hiện sắp xếp trong ListView dựa trên kiểu được chọn
                if (kieuSapXep == TuyChon.MaSV)
                {
                    lvSinhVien.ListViewItemSorter = new ListViewItemComparer(0); // Sắp xếp theo cột Mã SV
                }
                else if (kieuSapXep == TuyChon.HoTen)
                {
                    lvSinhVien.ListViewItemSorter = new ListViewItemComparer(1); // Sắp xếp theo cột Họ Tên
                }
                else if (kieuSapXep == TuyChon.NgaySinh)
                {
                    lvSinhVien.ListViewItemSorter = new ListViewItemComparer(2); // Sắp xếp theo cột Ngày Sinh
                }

                lvSinhVien.Sort(); // Thực hiện sắp xếp
            }
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị form frmTuyChon để thực hiện tìm kiếm
            frmTuyChon tuyChonForm = new frmTuyChon();
            tuyChonForm.Text = "Tìm Kiếm";

            // Đặt chế độ tìm kiếm: bật GroupBox Tìm và làm mờ nút Sắp Xếp
            tuyChonForm.gboTim.Enabled = true; // Bật GroupBox Tìm
            tuyChonForm.btnSapXep.Enabled = false; // Làm mờ nút Sắp Xếp
            tuyChonForm.btnTim.Enabled = true; // Bật nút Tìm

            if (tuyChonForm.ShowDialog() == DialogResult.OK)
            {
                // Lấy giá trị từ TextBox txtTim và tùy chọn từ RadioButton
                string chuoiTim = tuyChonForm.ChuoiTim;

                if (string.IsNullOrWhiteSpace(chuoiTim))
                {
                    MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TuyChon kieuTimKiem = tuyChonForm.Kieu;
                int foundCount = 0; // Đếm số kết quả tìm thấy

                // Duyệt qua tất cả các mục trong ListView
                foreach (ListViewItem item in lvSinhVien.Items)
                {
                    bool isMatch = false;

                    // So sánh từng dòng trong ListView dựa trên kiểu tìm kiếm
                    if (kieuTimKiem == TuyChon.MaSV && item.SubItems[0].Text.Equals(chuoiTim, StringComparison.OrdinalIgnoreCase))
                    {
                        isMatch = true;
                    }
                    else if (kieuTimKiem == TuyChon.HoTen && item.SubItems[1].Text.Contains(chuoiTim, StringComparison.OrdinalIgnoreCase))
                    {
                        isMatch = true;
                    }
                    else if (kieuTimKiem == TuyChon.NgaySinh && item.SubItems[2].Text.Equals(chuoiTim, StringComparison.OrdinalIgnoreCase))
                    {
                        isMatch = true;
                    }

                    // Đánh dấu các mục tìm thấy
                    if (isMatch)
                    {
                        item.Selected = true;
                        item.BackColor = Color.Yellow; // Đổi màu nền để hiển thị kết quả
                        foundCount++;
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = Color.White; // Trả về màu nền mặc định
                    }
                }

                // Hiển thị kết quả
                if (foundCount > 0)
                {
                    MessageBox.Show($"Số sinh viên tìm thấy: {foundCount}", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

    public class ListViewItemComparer : IComparer
    {
        private int col;

        public ListViewItemComparer(int column)
        {
            col = column;
        }

        public int Compare(object? x, object? y) // Cho phép nullable theo giao diện IComparer
        {
            // Kiểm tra null trước khi sử dụng
            if (x == null && y == null) return 0; // Cả hai đều null => bằng nhau
            if (x == null) return -1; // x null => y lớn hơn
            if (y == null) return 1; // y null => x lớn hơn

            // Thực hiện so sánh
            return string.Compare(
                ((ListViewItem)x).SubItems[col].Text,
                ((ListViewItem)y).SubItems[col].Text,
                StringComparison.OrdinalIgnoreCase
            );
        }
    }
}
