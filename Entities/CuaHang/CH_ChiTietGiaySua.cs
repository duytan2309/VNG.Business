using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_ChiTietGiaySua
    {
        public int Id { get; set; }
        public string SoGiaySua { get; set; }
        public string CuaHang { get; set; }
        public string DiaChiCuaHang { get; set; }
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayDeNghiGiao { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public decimal? Gia { get; set; }
        public decimal? Gia2 { get; set; }
        public int? SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal ThanhTien2 { get; set; }
        public decimal TongThanhTien { get; set; }
        public decimal TienKhachDua { get; set; }
        public decimal TienConTraLai { get; set; }
        public string MoTaLoi { get; set; }
        public string XuLy { get; set; }
        public string GhiChu { get; set; }
        public string GhiChuGiaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
