using System;

namespace VNG.Business.Entities.System
{
    public class SYS_User
    {
        public string status { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string MaCuaHang { get; set; }
        public bool? KichHoat { get; set; }
        public int? MaNhom { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
