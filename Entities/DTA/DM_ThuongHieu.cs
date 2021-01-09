using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_ThuongHieu
    {
        public string status { get; set; }
        public string MaThuongHieu { get; set; }
        public string ThuongHieu { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
