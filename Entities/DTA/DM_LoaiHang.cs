using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_LoaiHang
    {
        public string status { get; set; }
        public string MaLoaiHang { get; set; }
        public string TenGoi { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
