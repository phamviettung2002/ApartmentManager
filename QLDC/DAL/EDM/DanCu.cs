//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDC.DAL.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanCu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanCu()
        {
            this.DanCu_DichVu = new HashSet<DanCu_DichVu>();
        }
    
        public string MaDC { get; set; }
        public string TenDC { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string MaCH { get; set; }
        public int TrangThai { get; set; }
    
        public virtual CanHo CanHo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanCu_DichVu> DanCu_DichVu { get; set; }
    }
}
