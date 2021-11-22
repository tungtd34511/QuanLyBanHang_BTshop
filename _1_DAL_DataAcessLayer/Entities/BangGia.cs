using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("BANGGIA")]
    [Serializable]
    public class BangGia
    {
        [Key]
        public int Id { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int GiamGia { get; set; }
    }
}
