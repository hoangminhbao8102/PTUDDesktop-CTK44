using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lab05
{
    public class QLSinhVien
    {
        public List<SinhVien> DanhSachSinhVien { get; private set; }

        // Constructor
        public QLSinhVien()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }

        // a. Thêm hoặc cập nhật thông tin sinh viên (có lưu vào file)
        // a1. Thêm thông tin sinh viên
        public void ThemSinhVien(SinhVien sv, string filePath)
        {
            // Kiểm tra nếu sinh viên đã tồn tại
            if (DanhSachSinhVien.Any(s => s.MSSV == sv.MSSV))
            {
                Console.WriteLine($"Sinh viên với MSSV {sv.MSSV} đã tồn tại. Không thể thêm mới!");
                return;
            }

            // Thêm sinh viên mới
            DanhSachSinhVien.Add(sv);
            Console.WriteLine($"Thêm sinh viên mới MSSV: {sv.MSSV}");

            // Lưu lại danh sách vào file
            GhiRaFileTXT(filePath);
            GhiRaFileXML(filePath);
            GhiRaFileJSON(filePath);
        }

        // a2. Cập nhật thông tin sinh viên
        public void CapNhatSinhVien(SinhVien sv, string filePath)
        {
            // Tìm sinh viên dựa trên MSSV
            var sinhVienTonTai = DanhSachSinhVien.FirstOrDefault(s => s.MSSV == sv.MSSV);
            if (sinhVienTonTai == null)
            {
                Console.WriteLine($"Không tìm thấy sinh viên với MSSV {sv.MSSV}. Không thể cập nhật!");
                return;
            }

            // Cập nhật thông tin sinh viên
            sinhVienTonTai.HoVaTenLot = sv.HoVaTenLot;
            sinhVienTonTai.Ten = sv.Ten;
            sinhVienTonTai.NgaySinh = sv.NgaySinh;
            sinhVienTonTai.Lop = sv.Lop;
            sinhVienTonTai.CMND = sv.CMND;
            sinhVienTonTai.SoDienThoai = sv.SoDienThoai;
            sinhVienTonTai.DiaChiLienLac = sv.DiaChiLienLac;
            sinhVienTonTai.GioiTinh = sv.GioiTinh;
            sinhVienTonTai.MonHocDangKy = sv.MonHocDangKy;

            Console.WriteLine($"Cập nhật thông tin sinh viên MSSV: {sv.MSSV}");

            // Lưu lại danh sách vào file
            GhiRaFileTXT(filePath);
            GhiRaFileXML(filePath);
            GhiRaFileJSON(filePath);
        }

        // b. Tìm kiếm sinh viên theo Tên, Lớp, MSSV
        public List<SinhVien> TimKiemSinhVien(string keyword)
        {
            // Sử dụng Linq để tìm kiếm
            return DanhSachSinhVien
                .Where(sv => sv.Ten.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                             sv.Lop.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                             sv.MSSV.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // c. Xóa một hay nhiều sinh viên (có lưu vào file)
        public void XoaSinhVien(List<string> danhSachMSSV, string filePath)
        {
            foreach (var mssv in danhSachMSSV)
            {
                var sinhVien = DanhSachSinhVien.FirstOrDefault(sv => sv.MSSV == mssv);
                if (sinhVien != null)
                {
                    DanhSachSinhVien.Remove(sinhVien);
                    Console.WriteLine($"Đã xóa sinh viên MSSV: {mssv}");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy sinh viên MSSV: {mssv}");
                }
            }

            // Lưu lại danh sách vào file
            GhiRaFileTXT(filePath);
            GhiRaFileXML(filePath);
            GhiRaFileJSON(filePath);
        }

        // Phương thức đọc danh sách sinh viên từ file TXT
        public void DocTuFileTXT(string filePath)
        {
            if (!File.Exists(filePath)) return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 10)
                    {
                        var sv = new SinhVien
                        {
                            MSSV = parts[0],
                            HoVaTenLot = parts[1],
                            Ten = parts[2],
                            NgaySinh = DateTime.Parse(parts[3]),
                            Lop = parts[4],
                            CMND = parts[5],
                            SoDienThoai = parts[6],
                            DiaChiLienLac = parts[7],
                            GioiTinh = parts[8] == "Nam",
                            MonHocDangKy = parts[9].Split(',').ToList()
                        };
                        DanhSachSinhVien.Add(sv);
                    }
                }
            }
        }

        // Phương thức ghi danh sách sinh viên ra file TXT
        public void GhiRaFileTXT(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var sv in DanhSachSinhVien)
                {
                    string gioiTinh = sv.GioiTinh ? "Nam" : "Nữ";
                    string monHoc = string.Join(",", sv.MonHocDangKy);
                    writer.WriteLine($"{sv.MSSV}|{sv.HoVaTenLot}|{sv.Ten}|{sv.NgaySinh:dd/MM/yyyy}|{sv.Lop}|{sv.CMND}|{sv.SoDienThoai}|{sv.DiaChiLienLac}|{gioiTinh}|{monHoc}");
                }
            }
        }

        // Phương thức đọc danh sách sinh viên từ file XML
        public void DocTuFileXML(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var serializer = new XmlSerializer(typeof(List<SinhVien>));
            using (var reader = new StreamReader(filePath))
            {
                var result = serializer.Deserialize(reader);
                DanhSachSinhVien = result as List<SinhVien> ?? new List<SinhVien>();
            }
        }

        // Phương thức ghi danh sách sinh viên từ file XML
        public void GhiRaFileXML(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<SinhVien>));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, DanhSachSinhVien);
            }
        }

        // Phương thức đọc danh sách sinh viên từ file JSON
        public void DocTuFileJSON(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var json = File.ReadAllText(filePath);
            DanhSachSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(json) ?? new List<SinhVien>();
        }

        // Phương thức ghi danh sách sinh viên vào file JSON
        public void GhiRaFileJSON(string filePath)
        {
            // Chỉ định rõ không gian tên của Formatting
            var json = JsonConvert.SerializeObject(DanhSachSinhVien, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
