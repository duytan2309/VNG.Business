using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_QuanLyGia
    {
        public string status { get; set; }
        public string TinhTrang { get; set; }
        public int Id { get; set; }
        public string Kieu { get; set; }
        public string TenChungLoai { get; set; }
        public string NoiApDung { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaXuat { get; set; }
        public bool? Duyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayApDung { get; set; }
        public DateTime? NgayThayDoi { get; set; }
        public string NguoiThayDoi { get; set; }
    }
}
