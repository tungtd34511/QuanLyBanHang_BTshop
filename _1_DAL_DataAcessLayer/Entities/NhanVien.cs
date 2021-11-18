using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("NHANVIEN")]
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }
        [StringLength(35)]
        public string Ten { get; set; } 
        [ForeignKey("MaChucVu")]
        public ChucVu ChucVu { get; set; }
        public bool TinhTrang { get; set; }
        [ForeignKey("MaMoTa")]
        public ThongTinCaNhan ThongTinCaNhan { get; set; }
    }
}
