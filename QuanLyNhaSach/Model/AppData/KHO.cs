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
    
    public partial class KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHO()
        {
            this.NHATKINHAPSACHes = new HashSet<NHATKINHAPSACH>();
        }
    
        public string MASACH { get; set; }
        public Nullable<int> TONGSOLUONG { get; set; }
        public Nullable<int> SOLUONGCON { get; set; }
    
        public virtual SACH SACH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHATKINHAPSACH> NHATKINHAPSACHes { get; set; }
    }
}
