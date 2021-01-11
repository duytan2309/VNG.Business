using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_QuyDinhTinhDiem
    {
        public int Id { get; set; }
        public DateTime? NgayApDung { get; set; }
        public decimal? GiaTri { get; set; }
        public int? SoDiem { get; set; }
        public int? HeSoQuyDoi { get; set; }
        public int? SoDiemToiThieu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
