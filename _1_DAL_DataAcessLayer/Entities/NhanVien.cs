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
        public virtual ChucVu ChucVu { get; set; }
        public bool TinhTrang { get; set; }
        [ForeignKey("MaMoTa")]
        public virtual ThongTinCaNhan ThongTinCaNhan { get; set; }
        public object Sdt { get; set; }
        public object Email { get; set; }
        public object NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public object GhiChu { get; set; }
        public object MaAnh { get; set; }
        public object DiaChi { get; set; }
    }
}
