using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_BaiTap
{
    public partial class frmTimThongTin : Form
    {
        private QuanLyGiaoVien quanLyGiaoVien = new QuanLyGiaoVien();

        public frmTimThongTin()
        {
            InitializeComponent();
        }

        private void rdMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                lbTimTheo.Text = "Mã GV";
            }
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
            {
                lbTimTheo.Text = "Họ tên";
            }
        }

        private void rdSoDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSoDT.Checked)
            {
                lbTimTheo.Text = "Số điện thoại";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            GiaoVien? gvTimDuoc = null;

            // Kiểm tra tiêu chí tìm kiếm
            if (rdMaGV.Checked)
            {
                gvTimDuoc = quanLyGiaoVien.Tim(keyword, (a, b) =>
                {
                    GiaoVien? gv = b as GiaoVien;
                    return gv != null && gv.MaSo == (string)a ? 0 : -1;
                });
            }
            else if (rdHoTen.Checked)
            {
                gvTimDuoc = quanLyGiaoVien.Tim(keyword, (a, b) =>
                {
                    GiaoVien? gv = b as GiaoVien;
                    return gv != null && gv.HoTen.Contains((string)a, StringComparison.OrdinalIgnoreCase) ? 0 : -1;
                });
            }
            else if (rdSoDT.Checked)
            {
                gvTimDuoc = quanLyGiaoVien.Tim(keyword, (a, b) =>
                {
                    GiaoVien? gv = b as GiaoVien;
                    return gv != null && gv.SoDT == (string)a ? 0 : -1;
                });
            }

            // Xử lý kết quả tìm kiếm
            if (gvTimDuoc != null)
            {
                frmTBGiaoVien frm = new frmTBGiaoVien();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
