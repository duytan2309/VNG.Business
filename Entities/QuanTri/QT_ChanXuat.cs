using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_ChanXuat
    {
        public int ID { get; set; }
        public DateTime? DenNgay { get; set; }
        public string MaPhanLoai { get; set; }
        public string Kieu { get; set; }
        public string Loai { get; set; }
        public string NoiApDung { get; set; }
        public DateTime? TuNgay { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
