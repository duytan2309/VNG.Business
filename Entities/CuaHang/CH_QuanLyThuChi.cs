using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_QuanLyThuChi
    {
        public string MaCuaHang { get; set; }
        public DateTime? NgayTon { get; set; }
        public decimal QuyTonDau { get; set; }
        public decimal QuyTonCuoi { get; set; }
        public decimal Thu { get; set; }
        public decimal Chi { get; set; }
    }

    public class CH_QuanLyThuChi_ChiTiet
    {
        public int ID { get; set; }
        public string MaPhieu { get; set; }
        public DateTime? Ngay { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string MaCuaHang { get; set; }
        public string LoaiPhieu { get; set; }
        public string LoaiThuChi { get; set; }
        public string LoaiPhatSinh { get; set; }
        public decimal? TienPhatSinh { get; set; }
        public string NguoiThucHien { get; set; }
        public string Ca { get; set; }
        public decimal? SoDuCuoi { get; set; }
        public string LyDo { get; set; }
        public int? IsDeleted { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public decimal Thu { get; set; }
        public decimal Chi { get; set; }
    }
}
