using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Login.Model
{
    internal class taiKhoanModel
    {
        public class QuanLyTaiKhoanModel
        {
            // Các thuộc tính với Auto-Implemented Properties
            public string TenDangNhap { get; set; }
            public string HoVaTen { get; set; }
            public string Email { get; set; }
            public string MatKhau { get; set; }
            public string GioiTinh { get; set; }

            // Thuộc tính TypeUser với giá trị mặc định là "User"
            public string TypeUser { get; set; } = "User";

            // Constructor không tham số
            public QuanLyTaiKhoanModel()
            {
            }

            // Constructor có tham số
            public QuanLyTaiKhoanModel(string tenDangNhap, string hoVaTen, string email, string matKhau, string gioiTinh, string typeUser = "User")
            {
                HoVaTen = hoVaTen;
                TenDangNhap = tenDangNhap;
                Email = email;
                MatKhau = matKhau;
                GioiTinh = gioiTinh;
                TypeUser = typeUser; // Giá trị mặc định là "User" nếu không truyền vào
            }

            // Override ToString để in thông tin tài khoản (không hiển thị mật khẩu)
            public override string ToString()
            {
                return $"QuanLyTaiKhoanModel {{ HoVaTen = {HoVaTen}, TenDangNhap = {TenDangNhap}, Email = {Email}, GioiTinh = {GioiTinh}, TypeUser = {TypeUser} }}";
            }
        }
    }
}
