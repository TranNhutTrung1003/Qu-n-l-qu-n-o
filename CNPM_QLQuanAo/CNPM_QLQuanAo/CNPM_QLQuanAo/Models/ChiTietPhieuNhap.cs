//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_QLQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public string MaPhieu { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> GiaGoc { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
