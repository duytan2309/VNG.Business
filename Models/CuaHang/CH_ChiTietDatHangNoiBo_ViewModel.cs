using System;

namespace VNG.Business.Models.CuaHang
{
    public class CH_ChiTietDatHangNoiBo_ViewModel
    {
        public int option { get; set; }
        public int Id { get; set; }
        public string SoHoaDon { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
