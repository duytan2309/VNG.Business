namespace VNG.Business.Models.System
{
    public class SYS_Permission_ViewModel
    {
        public int option { get; set; }
        public int ID { get; set; }
        public int? MaNhom { get; set; }
        public string MaMenu { get; set; }
        public bool? Xem { get; set; }
        public bool? Luu { get; set; }
        public bool? Xoa { get; set; }
        public bool? Sua { get; set; }
        public bool? In { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public string TenDangNhap { get; set; }
    }
}
