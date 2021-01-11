using System;

namespace VNG.Business.Models.QuanTri
{
    public class QT_SanPhamKhuyenMai_ViewModel
    {
        public int option { get; set; }
        public string Id { get; set; }
        public string MaCuaHang { get; set; }
        public string Kieu { get; set; }
        public string MaChungLoai { get; set; }
        public string TenChungLoai { get; set; }
        public int? PhanTramGiam { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public bool? KhongGioiHan { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
