using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_BaiTap
{
    public class DanhMucMonHoc
    {
        public ArrayList ds;
        public DanhMucMonHoc()
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return (ds[index] as MonHoc) ?? new MonHoc(); } // Trả về đối tượng mặc định nếu là null
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sách môn học:";
            foreach (object mh in ds)
            {
                s += (mh as MonHoc)?.ToString() + ";"; // Chuyển về chuỗi nếu không null
            }
            return s;
        }
    }
}
