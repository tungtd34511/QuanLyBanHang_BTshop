using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("TAIKHOAN")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MaNhanVien")]
        public int NhanVien { get; set; }
       [StringLength(25)]
       public string Acc { get; set; }
       [StringLength(25)]
       public string Pass { get; set; }
       public bool TinhTrang { get; set; }
    }
}
