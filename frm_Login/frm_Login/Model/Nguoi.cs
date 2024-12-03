using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Login.Model
{
    internal class Nguoi
    {
        public class NguoiModel
        {
            public string HoVaTen { get; set; }
            public string SoDienThoai { get; set; }
            public string Email { get; set; }
            public DateTime? NgaySinh { get; set; }
            public string GioiTinh { get; set; }
            public string HinhAnh { get; set; }
            public string DiaChi { get; set; }

            // Constructor mặc định
            public NguoiModel() { }

            // Constructor khởi tạo cho đăng ký
            public NguoiModel(string hoVaTen, string soDienThoai, string email, string gioiTinh, string hinhAnh, string diaChi)
            {
                HoVaTen = hoVaTen;
                SoDienThoai = soDienThoai;
                Email = email;
                GioiTinh = gioiTinh;
                HinhAnh = hinhAnh;
                DiaChi = diaChi;
            }

            // Constructor đầy đủ
            public NguoiModel(string hoVaTen, string soDienThoai, string email, DateTime ngaySinh, string gioiTinh, string hinhAnh, string diaChi)
            {
                HoVaTen = hoVaTen;
                SoDienThoai = soDienThoai;
                Email = email;
                NgaySinh = ngaySinh;
                GioiTinh = gioiTinh;
                HinhAnh = hinhAnh;
                DiaChi = diaChi;
            }

            // Phương thức chuyển đổi hình ảnh thành Icon
            public Icon ToIcon()
            {
                try
                {
                    string imagePath = $"hinhAnh/{HinhAnh}.png";
                    return Icon.ExtractAssociatedIcon(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
                    return null;
                }
            }

            // Ghi đè phương thức ToString
            public override string ToString()
            {
                return $"NguoiModel {{ HoVaTen = {HoVaTen}, SoDienThoai = {SoDienThoai}, Email = {Email}, GioiTinh = {GioiTinh}, DiaChi = {DiaChi} }}";
            }
        }
    }
}
