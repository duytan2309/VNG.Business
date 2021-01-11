using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_PhieuTang
    {
        public string status { get; set; }
        public string TinhTrang { get; set; }
        public int Id { get; set; }
        public string MaPhieu { get; set; }
        public string EventName { get; set; }
        public decimal? GiaTri { get; set; }
        public string CuaHang { get; set; }
        public string NoiThuHoi { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public bool IsApprove { get; set; }
        public DateTime? NgayPhatHanh { get; set; }
        public bool IsPhatHanh { get; set; }
        public DateTime? NgayThuHoi { get; set; }
        public bool IsThuHoi { get; set; }
        public decimal? GiaTriThuHoi { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
