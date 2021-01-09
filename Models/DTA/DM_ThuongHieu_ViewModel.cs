using System;

namespace VNG.Business.Models.DTA
{
    public class DM_ThuongHieu_ViewModel
    {
        public int option { get; set; }
        public string MaThuongHieu { get; set; }
        public string ThuongHieu { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
