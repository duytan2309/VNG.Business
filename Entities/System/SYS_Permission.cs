using System;

namespace VNG.Business.Entities.System
{
    public class SYS_Permission
    {
        public int ID { get; set; }
        public int kiemtra { get; set; }
        public int? MaNhom { get; set; }
        public string NhomPhanQuyen { get; set; }
        public string MaMenu { get; set; }
        public string PhanHe { get; set; }
        public string ChucNang { get; set; }
        public bool? Xem { get; set; }
        public bool? Luu { get; set; }
        public bool? Xoa { get; set; }
        public bool? Sua { get; set; }
        public bool? In { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
