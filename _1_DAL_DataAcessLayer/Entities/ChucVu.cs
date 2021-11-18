using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("CHUCVU")]
    public class ChucVu
    {
        [Key]
        public int Id { set; get; }
        [StringLength(25)]
        public string TenChucVu { set; get; }
    }
}
