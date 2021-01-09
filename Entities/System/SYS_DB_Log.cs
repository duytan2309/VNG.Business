using System;

namespace VNG.Business.Entities.System
{
    public class SYS_DB_Log
    {
        public int Id { get; set; }
        public string PhanHe { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string ChucNang { get; set; }
        public string NoiDung { get; set; }
        public string NoiThucHien { get; set; }
    }
}
