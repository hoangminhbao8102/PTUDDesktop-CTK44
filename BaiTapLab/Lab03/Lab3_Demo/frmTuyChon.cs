using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }

    public partial class frmTuyChon : Form
    {
        public string ChuoiTim;
        public TuyChon Kieu;

        public frmTuyChon()
        {
            ChuoiTim = string.Empty;
            Kieu = TuyChon.MaSV;
            InitializeComponent();
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            // Gán giá trị mặc định khi form được load
            rdMaSV.Checked = true; // Mặc định sắp xếp hoặc tìm kiếm theo Mã SV
            ChuoiTim = string.Empty;
            Kieu = TuyChon.MaSV;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            // Xác định kiểu sắp xếp dựa trên tùy chọn
            if (rdMaSV.Checked)
            {
                Kieu = TuyChon.MaSV;
            }
            else if (rdHoTen.Checked)
            {
                Kieu = TuyChon.HoTen;
            }
            else if (rdNgaySinh.Checked)
            {
                Kieu = TuyChon.NgaySinh;
            }

            // Đóng form và trả về DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form mà không thực hiện gì
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không nhập thông tin tìm kiếm
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin tìm kiếm
            ChuoiTim = txtTim.Text;

            // Xác định kiểu tìm kiếm
            if (rdMaSV.Checked)
            {
                Kieu = TuyChon.MaSV;
            }
            else if (rdHoTen.Checked)
            {
                Kieu = TuyChon.HoTen;
            }
            else if (rdNgaySinh.Checked)
            {
                Kieu = TuyChon.NgaySinh;
            }

            // Đóng form và trả về DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
