namespace VNG.Business.Models.QuanTri
{
    public class QT_QuyDinhTinhDiem_ViewModel
    {
        public int option { get; set; }
        public int Id { get; set; }
        public string NgayApDung { get; set; }
        public decimal? GiaTri { get; set; }
        public int? SoDiem { get; set; }
        public int? HeSoQuyDoi { get; set; }
        public int? SoDiemToiThieu { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiCapNhat { get; set; }
    }
}
