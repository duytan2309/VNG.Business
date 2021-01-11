namespace VNG.Business.Entities.KhoTong
{
    public class KT_TonKho
    {
        public string status { get; set; }
        public int Id { get; set; }
        public string NoiTon { get; set; }
        public string TenChungLoai { get; set; }
        public string Kieu { get; set; }
        public string Size { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? PhanThung { get; set; }
        public int? SLTon { get; set; }
        public int? TC { get; set; }
        public int Size00 { get; set; }
        public int Size29 { get; set; }
        public int Size30 { get; set; }
        public int Size31 { get; set; }
        public int Size32 { get; set; }
        public int Size33 { get; set; }
        public int Size34 { get; set; }
        public int Size35 { get; set; }
        public int Size36 { get; set; }
        public int Size37 { get; set; }
        public int Size38 { get; set; }
        public int Size39 { get; set; }
        public int Size40 { get; set; }
        public int Size41 { get; set; }
        public int Size42 { get; set; }
        public int Size43 { get; set; }
        public int Size44 { get; set; }
        public int Size45 { get; set; }
        public int Size46 { get; set; }

        // Kiểm tra số lượng tồn với số lượng truyền vào 
        /// <summary>
        /// >= 0 : SoLuong > SLTon , < 0: SoLuong> SLTon
        /// </summary>
        public int? EqualSoLuong_SLTon { get; set; }
    }
}
