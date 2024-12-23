using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_login
{
    [Table("DoanhThu")]
    public class DoanhThu
    {
        [Key]
        public string MaDoanhThu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDichVu { get; set; }

        [Required]
        public DateTime NgayHoaDon { get; set; }

        public decimal Gia { get; set; }
    }
}
