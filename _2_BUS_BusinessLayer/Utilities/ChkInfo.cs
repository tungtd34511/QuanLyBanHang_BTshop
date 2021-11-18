using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class ChkInfo
    {
        public ChkInfo()
        {
        }

        public string chkTinhTrangSP(int input)
        {
            if (input == 1)
            {
                return "Mở bán";
            }
            return "Không mở bán";
        }
    }
}
