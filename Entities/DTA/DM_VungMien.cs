using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_VungMien
    {
        public string status { get; set; }
        public string MaVungMien { get; set; }
        public string TenVungMien { get; set; }
        public string GhiChu { get; set; }
        public bool? Is_Active { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }
    }
}
