using System;

namespace VNG.Business.Entities.System
{
    public class SYS_GroupPermission
    {
        public int ID { get; set; }
        public string NhomPhanQuyen { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
