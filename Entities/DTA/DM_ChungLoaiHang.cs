using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_ChungLoaiHang
    {
        public string status { get; set; }
        public string MaChungLoai { get; set; }
        public int? STT_PL { get; set; }
        public string TenChungLoai { get; set; }
        public int? PhanThung { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
