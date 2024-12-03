using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Login.Model
{
    internal class lichkham
    {
        public class DatLichKhamModel
        {
            public string MaDatLich { get; set; }
            public float GiaDichVuKham { get; set; }
            public string ThoiGioiKham { get; set; }
            public string DiaChiKham { get; set; }
            public string TrangThaiThanhToan { get; set; }
            public string TenDangNhap { get; set; }
            public string MaBacSi { get; set; }

            // Constructor không tham số
            public DatLichKhamModel() { }

            // Constructor có tham số
            public DatLichKhamModel(
                string maDatLich,
                float giaDichVuKham,
                string thoiGioiKham,
                string diaChiKham,
                string trangThaiThanhToan,
                string tenDangNhap,
                string maBacSi)
            {
                MaDatLich = maDatLich;
                GiaDichVuKham = giaDichVuKham;
                ThoiGioiKham = thoiGioiKham;
                DiaChiKham = diaChiKham;
                TrangThaiThanhToan = trangThaiThanhToan;
                TenDangNhap = tenDangNhap;
                MaBacSi = maBacSi;
            }

            // Override phương thức ToString
            public override string ToString()
            {
                return $"DatLichKhamModel {{ MaDatLich = {MaDatLich}, GiaDichVuKham = {GiaDichVuKham}, ThoiGioiKham = {ThoiGioiKham}, DiaChiKham = {DiaChiKham}, TenDangNhap = {TenDangNhap}, MaBacSi = {MaBacSi} }}";
            }
        }
    }
}
