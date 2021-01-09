using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_GiayDatChiTiet
    {
        public int? ID { get; set; }
        public string HoaDonDatHang { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public decimal Gia { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
        ///////////////////////////////
        public string CuaHang { get; set; }
        public string DiaChiCuaHang { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string NgayDatHang { get; set; }
        public string NgayYeuCauGiao { get; set; }
        public string NgayGiaoHang { get; set; }
        public string Label_KieuSize { get; set; }
        public decimal Gia2 { get; set; }
        public decimal ThanhTien2 { get; set; }
        public string TinhTrang { get; set; }
    }
}
