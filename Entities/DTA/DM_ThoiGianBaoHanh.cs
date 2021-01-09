using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_ThoiGianBaoHanh
    {
        public string status { get; set; }
        public string MaTGBH { get; set; }
        public string NoiDung { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
