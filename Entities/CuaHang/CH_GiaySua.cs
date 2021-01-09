using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_GiaySua
    {
        public string TinhTrang { get; set; }
        public string SoGiaySua { get; set; }
        public string CuaHang { get; set; }
        public string DiaChiCuaHang { get; set; }
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string ThuongTru { get; set; }
        public int? Ca { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNV { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayDeNghiGiao { get; set; }
        public DateTime? NgayXuatTra { get; set; }
        public decimal? TienConTraLai { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? TongThanhTien { get; set; }
        public string NoiXuatTra { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? TraGiay { get; set; }
    }
}
