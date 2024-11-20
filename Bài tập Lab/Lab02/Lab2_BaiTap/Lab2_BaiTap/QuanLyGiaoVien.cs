using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_BaiTap
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }

    public delegate int SoSanh(object a, object b);

    public class QuanLyGiaoVien
    {
        private List<GiaoVien> dsGiaoVien = new List<GiaoVien>();

        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }

        public QuanLyGiaoVien() { }

        public void Them(GiaoVien gv)
        {
            if (dsGiaoVien.Any(gvTrongDS => gvTrongDS.MaSo == gv.MaSo))
            {
                MessageBox.Show("Giáo viên với mã này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsGiaoVien.Add(gv);
            }
        }

        public GiaoVien Tim(object temp, SoSanh ss)
        {
            foreach (var gv in dsGiaoVien)
            {
                if (ss(temp, gv) == 0)
                    return gv; // Trả về đối tượng tìm thấy
            }

            // Trả về một đối tượng mặc định
            return new GiaoVien
            {
                MaSo = "Không rõ",
                HoTen = "Không tìm thấy",
                GioiTinh = "Không rõ",
                NgaySinh = DateTime.MinValue,
                SoDT = string.Empty,
                Mail = string.Empty,
                NgoaiNgu = Array.Empty<string>(),
                dsMonHoc = new DanhMucMonHoc()
            };
        }

        public void Xoa(object temp, SoSanh ss)
        {
            for (int i = dsGiaoVien.Count - 1; i >= 0; i--)
            {
                if (ss(temp, dsGiaoVien[i]) == 0)
                    dsGiaoVien.RemoveAt(i);
            }
        }

        public void SapXep(SoSanh ss)
        {
            dsGiaoVien.Sort((a, b) => ss(a, b));
        }
    }
}
