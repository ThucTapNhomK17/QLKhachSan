//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// OKe Test

namespace Hotel_SoftWare2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuThue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietPhieuThue()
        {
            this.SuDungDichVus = new HashSet<SuDungDichVu>();
        }
    
        public string MaChiTietPhieuThue { get; set; }
        public Nullable<System.DateTime> NgayVao { get; set; }
        public Nullable<System.DateTime> NgayRa { get; set; }
        public Nullable<bool> HinhThucThue { get; set; }
        public string SoLuongKhach { get; set; }
        public string MaPhong { get; set; }
        public string MaPhieuThuePhong { get; set; }
    
        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
        public virtual Phong Phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuDungDichVu> SuDungDichVus { get; set; }
    }
}
