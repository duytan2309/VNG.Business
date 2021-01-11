using System.Collections.Generic;
using VNG.Business.Entities.CuaHang;

namespace VNG.Business.Models.CuaHang
{
    public class CH_BanHang_ViewModel
    {
        public string Id { get; set; }
        public int option { get; set; }
        public string MaCuaHang { get; set; }
        public string MaKhachHang { get; set; }
        public string BarcodeScan { get; set; }
        public string SoHoaDonBan { get; set; }
        public int SoLuong { get; set; }
        public string MaPhieuTang { get; set; }
        public string MaNhanVien { get; set; }
        public decimal ThucNhan { get; set; }
        public string CreateBy { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        ////////////////
        public int? SoDiemChi { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public string MaNVTiepKhach { get; set; }
        public string NoiTon { get; set; }
        public string BarcodeOrKieu { get; set; }
        public string Event { get; set; }
        /////////////////
        public decimal TongTien_KM { get; set; }
        public decimal? TongTienGiam { get; set; }


    }
}
