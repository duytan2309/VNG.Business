
namespace VNG.Business.Models.QuanTri
{
    public class QT_PhieuTang_ViewModel
    {
        public int option { get; set; }
        public string Id { get; set; }
        public string MaPhieu { get; set; }
        public string EventName { get; set; }
        public decimal? GiaTri { get; set; }
        public string CuaHang { get; set; }
        public string ApproveBy { get; set; }
        public string ApproveDate { get; set; }
        public bool IsApprove { get; set; }
        public string NgayPhatHanh { get; set; }
        public bool IsPhatHanh { get; set; }
        public string NgayThuHoi { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
