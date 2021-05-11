
namespace Hotel_SoftWare2
{
    using System;
    using System.Collections.Generic;

    
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            this.SuDungDichVus = new HashSet<SuDungDichVu>();
        }
    
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string MaLoaiDV { get; set; }
        public virtual LoaiDichVu LoaiDichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuDungDichVu> SuDungDichVus { get; set; }
    }
}
