using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static frm_Login.Model.Nguoi;

namespace frm_Login.Model
{
    internal class bacsi
    {
        public class BacSiModel : NguoiModel
        {
            public string MaBacSi { get; set; }
            public string ChuyenKhoa { get; set; }
            public string KinhNghiemLamViec { get; set; }
            public string HocVan { get; set; }

            // Constructor mặc định
            public BacSiModel() { }

            // Constructor với các thuộc tính riêng
            public BacSiModel(string maBacSi, string chuyenKhoa, string kinhNghiemLamViec, string hocVan)
            {
                MaBacSi = maBacSi;
                ChuyenKhoa = chuyenKhoa;
                KinhNghiemLamViec = kinhNghiemLamViec;
                HocVan = hocVan;
            }

            // Constructor đầy đủ (bao gồm cả thuộc tính của lớp cha)
            public BacSiModel(
                string maBacSi, string hoVaTen, string soDienThoai, string email, DateTime ngaySinh,
                string diaChi, string gioiTinh, string chuyenKhoa, string kinhNghiemLamViec,
                string hocVan, string hinhAnh
            ) : base(hoVaTen, soDienThoai, email, ngaySinh, gioiTinh, hinhAnh, diaChi)
            {
                MaBacSi = maBacSi;
                ChuyenKhoa = chuyenKhoa;
                KinhNghiemLamViec = kinhNghiemLamViec;
                HocVan = hocVan;
            }
        }
    }
}
