using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_KhachHang
    {
        public string status { get; set; }
        public int Id { get; set; }
        public string CMND { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Email { get; set; }
        public string GhiChu { get; set; }
        public string HoTen { get; set; }
        public bool? Is_Active { get; set; }
        public bool? Is_Delete { get; set; }
        public string MaKhachHang { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string TamTru { get; set; }
        public string ThuongTru { get; set; }

        //Thông tin tích điểm
        public string HoTen_TichDiem { get; set; }
        public decimal SoDiem { get; set; }
        public int HeSoQuyDoi { get; set; }
        public int SoDiemToiThieu { get; set; }
        public decimal TruocPhatSinh { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
