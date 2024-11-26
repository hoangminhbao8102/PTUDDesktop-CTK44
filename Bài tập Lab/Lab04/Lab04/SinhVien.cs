using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class SinhVien
    {
        // Thuộc tính của lớp SinhVien
        public string MSSV { get; set; }          // Mã số sinh viên (7 ký tự số)
        public string HoVaTen { get; set; }       // Họ và tên
        public string Phai { get; set; }          // Phái (Nam hoặc Nữ)
        public DateTime NgaySinh { get; set; }    // Ngày sinh
        public string Lop { get; set; }           // Lớp (CTK43, CTK44, CTK45, CTK46)
        public string SoDienThoai { get; set; }   // Số điện thoại (10 chữ số, phân tách 3 nhóm)
        public string Email { get; set; }         // Email
        public string DiaChi { get; set; }        // Địa chỉ
        public string Hinh { get; set; }          // Đường dẫn hình ảnh

        // Hàm khởi tạo không tham số
        public SinhVien()
        {
            this.MSSV = string.Empty;
            this.HoVaTen = string.Empty;
            this.Phai = string.Empty;
            this.NgaySinh = DateTime.MinValue;
            this.Lop = string.Empty;
            this.SoDienThoai = string.Empty;
            this.Email = string.Empty;
            this.DiaChi = string.Empty;
            this.Hinh = string.Empty;
        }

        // Hàm khởi tạo có tham số
        public SinhVien(string mssv, string hoVaTen, string phai, DateTime ngaySinh, string lop,
                        string soDienThoai, string email, string diaChi, string hinh)
        {
            this.MSSV = mssv;
            this.HoVaTen = hoVaTen;
            this.Phai = phai;
            this.NgaySinh = ngaySinh;
            this.Lop = lop;
            this.SoDienThoai = soDienThoai;
            this.Email = email;
            this.DiaChi = diaChi;
            this.Hinh = hinh;
        }
    }
}
