//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaSach.Model.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            this.SACHes = new HashSet<SACH>();
        }
    
        public int MATG { get; set; }
        public string TENTG { get; set; }
        public Nullable<System.DateTime> NAMSINH { get; set; }
        public Nullable<System.DateTime> NAMMAT { get; set; }
        public string QUEQUAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
