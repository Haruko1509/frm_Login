using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Login.Model
{
    internal class thanhtoan
    { 
        public class ThanhToanModel
        {
            public string MaThanhToan { get; set; }
            public string SoTaiKhoan { get; set; }
            public string TenTaiKhoan { get; set; }
            public string TenNganHang { get; set; }
            public string ThoiGianThanhToan { get; set; }
            public string TenDangNhap { get; set; }

            // Constructor không tham số
            public ThanhToanModel() { }

            // Constructor có tham số
            public ThanhToanModel(
                string maThanhToan,
                string soTaiKhoan,
                string tenTaiKhoan,
                string tenNganHang,
                string thoiGianThanhToan,
                string tenDangNhap)
            {
                MaThanhToan = maThanhToan;
                SoTaiKhoan = soTaiKhoan;
                TenTaiKhoan = tenTaiKhoan;
                TenNganHang = tenNganHang;
                ThoiGianThanhToan = thoiGianThanhToan;
                TenDangNhap = tenDangNhap;
            }
        }
    }
}
