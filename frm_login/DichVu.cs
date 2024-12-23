namespace frm_login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [Key]
        [StringLength(50)]
        public string MaDichVu { get; set; }

        [StringLength(100)]
        public string TenDichVu { get; set; }

        public decimal? Gia { get; set; }

        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
    }
}
