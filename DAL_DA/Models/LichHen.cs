namespace DAL_DA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichHen")]
    public partial class LichHen
    {
        [Key]
        [StringLength(50)]
        public string MaLichHen { get; set; }

        public DateTime? NgayHenTT { get; set; }

        public DateTime? NgayHenGN { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        [StringLength(1000)]
        public string Ghichu { get; set; }

        [StringLength(50)]
        public string MaDichVu { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
