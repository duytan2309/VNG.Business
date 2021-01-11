using System;

namespace VNG.Business.Entities.QuanTri
{
    public class QT_Kieu
    {
        public string TinhTrang { get; set; }
        public string status { get; set; }
        public int ID { get; set; }
        public string Barcode { get; set; }
        public string GhiChu { get; set; }
        public bool? Is_Active { get; set; }
        public bool? Is_Delete { get; set; }
        public string Kieu { get; set; }
        public string MaChungLoai { get; set; }
        public string TenChungLoai { get; set; }
        public string MaCungUng { get; set; }
        public string MaDongSanPham { get; set; }
        public string MaPhanLoai { get; set; }
        public string MaLoaiHang { get; set; }
        public string MaThuongHieu { get; set; }
        public int? MaxSize { get; set; }
        public int? MinSize { get; set; }
        public string MoTa { get; set; }
        public string TenGoi { get; set; }
        public string MaTGBH { get; set; }
        public int MaThuHoi { get; set; }
        public bool? IsCoHop { get; set; }
        public string Mau { get; set; }
        public string Got { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? MaDVT { get; set; }
        public decimal GiaNhap { get; set; }
    }
}
