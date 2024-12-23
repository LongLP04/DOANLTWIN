namespace frm_login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            DichVus = new HashSet<DichVu>();
            ToaThuocs = new HashSet<ToaThuoc>();
        }

        [Key]
        [StringLength(50)]
        public string MaHoaDon { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
        //public string MaDichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DichVu> DichVus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToaThuoc> ToaThuocs { get; set; }
        public string MaDichVu { get; internal set; }
    }
}
