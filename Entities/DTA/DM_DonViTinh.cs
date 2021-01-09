using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_DonViTinh
    {
        public int ID { get; set; }
        public string DVT { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
