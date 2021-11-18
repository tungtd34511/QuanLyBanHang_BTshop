using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("DONHANG")]
    public class DonHang
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MaHoaDon")]
        public HoaDon HoaDon { get; set; }
        [ForeignKey("MaSanPham")]
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public bool TinhTrang { get; set; }
    }
}
