using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_NhanVien
    {
        public string status { get; set; }
        public int Id { get; set; }
        public int Ca { get; set; }
        public string CMND { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Email { get; set; }
        public string GhiChu { get; set; }
        public string HoTen { get; set; }
        public bool? Is_Active { get; set; }
        public string MaNhanVien { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public string NguoiGioiThieu { get; set; }
        public string SoDienThoai { get; set; }
        public string TamTru { get; set; }
        public string ThuongTru { get; set; }
        public string MaCuaHang { get; set; }
    }
}
