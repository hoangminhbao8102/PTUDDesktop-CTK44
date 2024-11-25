using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    public delegate int SoSanh(object sv1, object sv2);

    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        // Thêm một sinh viên vào danh sách
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        //Xóa các obj trong danh sách nếu thỏa điều kiện so sánh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this.DanhSach.RemoveAt(i);
                }
            }
        }

        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh
        public SinhVien Tim(object obj, SoSanh ss)
        {
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj, sv) == 0)
                {
                    return sv; // Trả về sinh viên tìm thấy
                }
            }

            // Trả về một đối tượng SinhVien mặc định nếu không tìm thấy
            return new SinhVien
            {
                MaSo = "Unknown",
                HoTen = "Không tìm thấy",
                NgaySinh = DateTime.MinValue,
                DiaChi = "N/A",
                Lop = "N/A",
                Hinh = "N/A",
                GioiTinh = false,
                ChuyenNganh = new List<string>()
            };
        }

        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh, gán lại thông tin cho sinh viên này thành svsua
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

        // Hàm đọc danh sách sinh viên từ tập tin txt
        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt";
            string? t; // Cho phép giá trị null
            StreamReader? sr = null; // Khởi tạo StreamReader là nullable để kiểm tra null
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open));
                while ((t = sr.ReadLine()) != null) // Kiểm tra dòng có null hay không
                {
                    string[] s = t.Split('*');
                    if (s.Length < 8) // Kiểm tra nếu không đủ dữ liệu trong dòng
                    {
                        Console.WriteLine("Dòng dữ liệu không hợp lệ, bỏ qua.");
                        continue;
                    }

                    SinhVien sv = new SinhVien
                    {
                        MaSo = s[0] ?? "Unknown", // Xử lý null cho từng phần tử
                        HoTen = s[1] ?? "Unknown",
                        NgaySinh = DateTime.TryParse(s[2], out var ngaySinh) ? ngaySinh : DateTime.MinValue,
                        DiaChi = s[3] ?? "Unknown",
                        Lop = s[4] ?? "Unknown",
                        Hinh = s[5] ?? "Unknown",
                        GioiTinh = s[6] == "1",
                        ChuyenNganh = s[7]?.Split(',').ToList() ?? new List<string>()
                    };

                    this.Them(sv); // Thêm sinh viên vào danh sách
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
            finally
            {
                sr?.Close(); // Đóng StreamReader nếu nó được mở
            }
        }
    }
}
