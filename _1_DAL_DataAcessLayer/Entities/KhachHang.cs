using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("KHACHHANG")]
    [Serializable]
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }
        [StringLength(35)]
        public string Ten { get; set; }
        [StringLength(15)]
        public string SDT { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public bool TinhTrang { get; set; }
    }
}
