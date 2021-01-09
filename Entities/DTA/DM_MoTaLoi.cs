using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_MoTaLoi
    {
        public int Id { get; set; }
        public string MaLoi { get; set; }
        public string TenLoi { get; set; }
        public bool? IsUse { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
