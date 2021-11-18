using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLNuocHoaServices
    {
        void addNuocHoa(NuocHoa nuocHoa);
        void editNuocHoa(NuocHoa nuocHoa, int index);
        NuocHoa findNuocHoa(string input);
        List<NuocHoa> getlstNuocHoas();
    }
}
