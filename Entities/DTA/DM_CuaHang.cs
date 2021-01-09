using System;

namespace VNG.Business.Entities.DTA
{
    public class DM_CuaHang
    {
        public string status { get; set; }
        public string Id { get; set; }
        public string MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string Code { get; set; }
        public string MaVungMien { get; set; }
        public string UserName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public string PhanLoaiCuaHang { get; set; }
        public string Email { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string DiaChi { get; set; }
        public bool EmailConfirmed { get; set; }
        public string GhiChu { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public string SoDienThoai { get; set; }
        public string SoFax { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int? UuTien { get; set; }
        public bool? IsCuaHang { get; set; }
    }
}
