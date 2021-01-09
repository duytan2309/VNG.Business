using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_LoaiThuChi
    {
        public string MaLoaiThuChi { get; set; }
        public string LoaiThuChi { get; set; }
        public string LoaiPhieu { get; set; }
        public bool? IsUse { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string status { get; set; }
    }
}
