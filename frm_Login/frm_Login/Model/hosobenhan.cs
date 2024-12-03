using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Login.Model
{
    internal class hosobenhan
    {
        public class HosoBenhAnModel
        {
            public string MaHoSo { get; set; }
            public string TienSuBenhAn { get; set; }
            public string TrieuChung { get; set; }
            public string ChuanDoan { get; set; }
            public string KetLuan { get; set; }
            public string MaBenhNhan { get; set; }
            public string MaBacSi { get; set; }

            // Constructor không tham số
            public HosoBenhAnModel() { }

            // Constructor có tham số
            public HosoBenhAnModel(
                string maHoSo,
                string tienSuBenhAn,
                string trieuChung,
                string chuanDoan,
                string ketLuan,
                string maBenhNhan,
                string maBacSi)
            {
                MaHoSo = maHoSo;
                TienSuBenhAn = tienSuBenhAn;
                TrieuChung = trieuChung;
                ChuanDoan = chuanDoan;
                KetLuan = ketLuan;
                MaBenhNhan = maBenhNhan;
                MaBacSi = maBacSi;
            }
        }
    }
}
