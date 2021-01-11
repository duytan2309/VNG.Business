using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_LenhThuHoi
    {
        public int ID { get; set; }
        public string MaLenh { get; set; }
        public DateTime? NgayThuHoi { get; set; }
        public string MaCuaHang { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
        public bool? ApDung { get; set; }
    }
}
