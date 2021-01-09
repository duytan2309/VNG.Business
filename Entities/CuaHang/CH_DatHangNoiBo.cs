using System;

namespace VNG.Business.Entities.CuaHang
{
    public class CH_DatHangNoiBo
    {
        public string TinhTrang { get; set; }
        public string SoHoaDon { get; set; }
        public string MaCuaHangBan { get; set; }
        public string MaCuaHangDat { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string GhiChu { get; set; }
        public string MaNVBan { get; set; }
        public string HoTenNVBan { get; set; }
        public int? Ca { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
        public int Status { get; set; }
    }
}
