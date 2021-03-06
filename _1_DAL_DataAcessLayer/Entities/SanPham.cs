using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("SANPHAM")]
    [Serializable]
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public bool TinhTrang { get; set; }
        [StringLength(25)]
        public string MaQR { get; set; }
        [ForeignKey("MaBangGia")]
        public virtual BangGia BangGia { get; set; }
        [ForeignKey("MaXuatXu")]
        public virtual XuatXu XuatXu { get; set; }
        [ForeignKey("MaMoTa")]
        public virtual MoTaSanPham MoTaSanPham { get; set; }
    }
}
