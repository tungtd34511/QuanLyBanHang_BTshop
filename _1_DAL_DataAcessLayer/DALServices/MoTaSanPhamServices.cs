using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;

namespace _1_DAL_DataAcessLayer.DALServices
{
    public class MoTaSanPhamServices : IMoTaSanPhamServices

    {
    private List<MoTaSanPham> _lstMoTaSanPhams;
    private DBContext_BTShop _dbContext;

    public MoTaSanPhamServices()
    {
        _dbContext = new DBContext_BTShop();
        _lstMoTaSanPhams = new List<MoTaSanPham>();
        GetlstMoTaSanPhamsFromDB();
    }

    public List<MoTaSanPham> GetlstMoTaSanPhams()
    {
        return _lstMoTaSanPhams;
    }

    public void GetlstMoTaSanPhamsFromDB()
    {
        _lstMoTaSanPhams = _dbContext.MOTASANPHAM.ToList();
    }

    public string AddMoTaSanPham(MoTaSanPham moTaSanPham)
    {
        _dbContext.Add(moTaSanPham);
        _dbContext.SaveChanges();
        GetlstMoTaSanPhamsFromDB();
        return "Thêm thành công";
    }

    public string UpdateMoTaSanPham(MoTaSanPham moTaSanPham)
    {
        _dbContext.Update(moTaSanPham);
        _dbContext.SaveChanges();
        GetlstMoTaSanPhamsFromDB();
        return "Sửa thành công";
    }

    public string DeleteMoTaSanPham(int id)
    {
        _dbContext.Remove(_lstMoTaSanPhams.FirstOrDefault(c => c.Id == id));
        _dbContext.SaveChanges();
        GetlstMoTaSanPhamsFromDB();
        return "Xóa thành công";
    }
    }
}
