using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("MOTASANPHAM")]
    public class MoTaSanPham
    {
        [Key]
        public int Id { get; set; }
        public int DungTich { get; set; }
        [StringLength(25)]
        public string PhienBan { get; set; }
        [StringLength(100)]
        public string Anh { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public bool GioiTinh { get; set; }
    }
}
