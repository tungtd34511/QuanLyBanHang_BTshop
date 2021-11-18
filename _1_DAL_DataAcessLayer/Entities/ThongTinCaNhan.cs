using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("THONGTINCANHAN")]
    public class ThongTinCaNhan
    {
        [Key]
        public int Id { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(35)]
        public string Email { get; set; }
        [StringLength(15)]
        public string SDT { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string Anh { get; set; }
        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
