using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_BanHang
    {

        public int Id { get; set; }
        public string MaCuaHang { get; set; }
        public int Ca { get; set; }
        public string SoHoaDonBan { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? NgayBan { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public decimal? ThanhToan { get; set; }
        public decimal? TongThanhTien { get; set; }
        public decimal? TienKhachTra { get; set; }
        public decimal? TienGiam { get; set; }
        public decimal? ThucNhan { get; set; }
        public string MaPhieuTang { get; set; }
        public int? TGBH { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        ////////////////////
        public string status { get; set; }
        public string TinhTrang { get; set; }
        public string DiaChi { get; set; }
        public decimal? TongTien { get; set; }
        public string StrTongTien { get; set; }
        public decimal? Gia2 { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? ThanhTien2 { get; set; }
        public string Label_KieuSize { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string HoTenNV { get; set; }
        public decimal? TienPhieuTang { get; set; }
        public int? ChiecKhau { get; set; }
        public decimal? SoTienThua { get; set; }
    }
}
