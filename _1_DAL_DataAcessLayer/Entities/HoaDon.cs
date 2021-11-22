using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("HOADON")]
    [Serializable]
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MaKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public bool TheLoai { get; set; }
        public int GiamGia { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TinhTrangThanhToan { get; set; }
        public bool TinhTrang { get; set; }
    }
}
