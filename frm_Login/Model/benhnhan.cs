using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static frm_Login.Model.Nguoi;

namespace frm_Login.Model
{
    internal class benhnhan
    {


        public class BenhNhanModel : NguoiModel
        {
            public string MaBenhNhan { get; set; }
            public string TenDangNhap { get; set; }

            // Constructor mặc định
            public BenhNhanModel() { }

            // Constructor với mã bệnh nhân và tên đăng nhập
            public BenhNhanModel(string maBenhNhan, string tenDangNhap)
            {
                MaBenhNhan = maBenhNhan;
                TenDangNhap = tenDangNhap;
            }

            // Constructor với các thông tin cơ bản
            public BenhNhanModel(string tenDangNhap, string hoVaTen, string soDienThoai, string email, DateTime ngaySinh,
                string gioiTinh, string diaChi, string hinhAnh)
                : base(hoVaTen, soDienThoai, email, ngaySinh, gioiTinh, hinhAnh, diaChi)
            {
                TenDangNhap = tenDangNhap;
            }

            // Constructor với đầy đủ thông tin
            public BenhNhanModel(string maBenhNhan, string tenDangNhap, string hoVaTen, string soDienThoai, string email,
                DateTime ngaySinh, string gioiTinh, string diaChi, string hinhAnh)
                : base(hoVaTen, soDienThoai, email, ngaySinh, gioiTinh, hinhAnh, diaChi)
            {
                MaBenhNhan = maBenhNhan;
                TenDangNhap = tenDangNhap;
            } 
        }
    }
}

