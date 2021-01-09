using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_GiayDat
    {
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string HoaDonDatHang { get; set; }
        public string CuaHang { get; set; }
        public string MaNhanVien { get; set; }
        public int? Ca { get; set; }
        public string MaKhachHang { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? SoTienThua { get; set; }
        public string GhiChu { get; set; }
        public string NoiGiaoHang { get; set; }
        public decimal? TienCoc { get; set; }
        public decimal? CongThem { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayYeuCauGiao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public string NguoiThayDoi { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime? NgayDuyet { get; set; }
        //////////////////////
        public string TinhTrang { get; set; }
        public decimal? TongThanhTien { get; set; }
        public decimal? TienConLai { get; set; }
    }
}
