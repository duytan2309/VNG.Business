using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_SanPhamKhuyenMai
    {
        public int Id { get; set; }
        public string status { get; set; }
        public string TinhTrang { get; set; }
        public string MaCuaHang { get; set; }
        public string Kieu { get; set; }
        public string MaChungLoai { get; set; }
        public string TenChungLoai { get; set; }
        public int? PhanTramGiam { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public bool? Duyet { get; set; }
        public bool? KhongGioiHan { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
