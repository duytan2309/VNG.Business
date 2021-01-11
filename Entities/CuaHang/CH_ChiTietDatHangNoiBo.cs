using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_ChiTietDatHangNoiBo
    {
        public int? Id { get; set; }
        public string SoHoaDon { get; set; }
        public string MaCuaHangBan { get; set; }
        public string MaCuaHangDat { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string GhiChuDatHang { get; set; }
        public string MaNVBan { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
