//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Group17_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int MaChiTiet { get; set; }
        public string MaDonHang { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
