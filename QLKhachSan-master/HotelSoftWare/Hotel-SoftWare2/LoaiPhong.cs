
namespace Hotel_SoftWare2
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            this.Phongs = new HashSet<Phong>();
        }
    
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string SoNguoi { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
