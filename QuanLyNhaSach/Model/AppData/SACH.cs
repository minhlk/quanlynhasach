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
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public Nullable<int> MATG { get; set; }
        public string MALOAISACH { get; set; }
        public string MALINHVUC { get; set; }
        public Nullable<int> GIAMUA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual KHO KHO { get; set; }
        public virtual LINHVUC LINHVUC { get; set; }
        public virtual LOAISACH LOAISACH { get; set; }
        public virtual SACHKHUYENMAI SACHKHUYENMAI { get; set; }
        public virtual TACGIA TACGIA { get; set; }
        public virtual THONGTINXUATBAN THONGTINXUATBAN { get; set; }
    }
}
