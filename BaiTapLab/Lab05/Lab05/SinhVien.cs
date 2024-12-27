using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class SinhVien
    {
        // Các thuộc tính của Sinh viên
        public string MSSV { get; set; }          // Mã số sinh viên
        public string HoVaTenLot { get; set; }    // Họ và tên lót
        public string Ten { get; set; }           // Tên
        public DateTime NgaySinh { get; set; }    // Ngày sinh
        public string Lop { get; set; }           // Lớp
        public string CMND { get; set; }          // Số CMND
        public string SoDienThoai { get; set; }   // Số điện thoại
        public string DiaChiLienLac { get; set; } // Địa chỉ liên lạc
        public bool GioiTinh { get; set; }        // Giới tính (True = Nam, False = Nữ)
        public List<string> MonHocDangKy { get; set; } // Danh sách môn học đăng ký

        // Constructor mặc định
        public SinhVien()
        {
            MSSV = "";
            HoVaTenLot = "";
            Ten = "";
            NgaySinh = DateTime.MinValue;
            Lop = "";
            CMND = "";
            SoDienThoai = "";
            DiaChiLienLac = "";
            MonHocDangKy = new List<string>();
        }

        // Constructor có tham số
        public SinhVien(string mssv, string hoVaTenLot, string ten, DateTime ngaySinh,
                        string lop, string cmnd, string soDienThoai, string diaChiLienLac,
                        bool gioiTinh, List<string> monHocDangKy)
        {
            MSSV = mssv;
            HoVaTenLot = hoVaTenLot;
            Ten = ten;
            NgaySinh = ngaySinh;
            Lop = lop;
            CMND = cmnd;
            SoDienThoai = soDienThoai;
            DiaChiLienLac = diaChiLienLac;
            GioiTinh = gioiTinh;
            MonHocDangKy = monHocDangKy ?? new List<string>();
        }

        // Phương thức hiển thị thông tin sinh viên (dạng chuỗi)
        public override string ToString()
        {
            return $"MSSV: {MSSV}, Họ và tên: {HoVaTenLot} {Ten}, Ngày sinh: {NgaySinh.ToShortDateString()}, " +
                   $"Lớp: {Lop}, CMND: {CMND}, SĐT: {SoDienThoai}, Địa chỉ: {DiaChiLienLac}, " +
                   $"Giới tính: {(GioiTinh ? "Nam" : "Nữ")}, Môn học: {string.Join(", ", MonHocDangKy)}";
        }
    }
}
