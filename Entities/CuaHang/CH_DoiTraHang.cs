using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_DoiTraHang
    {
        public int Id { get; set; }
        public string CuaHang { get; set; }
        public string CuaHangTraHo { get; set; }
        public string TenKhachhang { get; set; }
        public string SoDienThoai { get; set; }
        public string SoHoaDonCu { get; set; }
        public string SoHoaDonMoi { get; set; }
        public string KieuCu { get; set; }
        public string KieuMoi { get; set; }
        public string SizeCu { get; set; }
        public string SizeMoi { get; set; }
        public decimal? GiaCu { get; set; }
        public decimal? GiaMoi { get; set; }
        public string Mau { get; set; }
        public string Got { get; set; }
        public decimal? TienGiam { get; set; }
        public decimal? ThanhTien { get; set; }
        public int SoLuong { get; set; }
        public string LyDoDoiTra { get; set; }
        public DateTime? NgayBan { get; set; }
        public string MaNhanVien { get; set; }
        public bool? IsGot { get; set; }
        public bool? IsDaTra { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
