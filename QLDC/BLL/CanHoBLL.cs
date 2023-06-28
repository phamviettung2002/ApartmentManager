using QLDC.DAL;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.BLL
{
    class CanHoBLL
    {
        public static List<CanHoDTO> GetAllCanHo()
        {
            return CanHoDAL.GetALLCanHo();
        }
        public static bool AddCanHo(CanHoDTO ch)
        {
            return CanHoDAL.AddcanHo(ch);
        }
        public static bool DeleteCanHo(string mach)
        {
            return CanHoDAL.DeleteCanHo(mach);
        }
        public static bool UpdateCanHo(string mach, CanHoDTO chdto)
        {
            return CanHoDAL.UpdateCanHo(mach, chdto);
        }
        public static CanHoDTO LoadCanHo(string mach)
        {
            return CanHoDAL.LoadCanHo(mach);
        }
        public static List<CanHoDTO> SearchCanHo(string mach)
        {
            return CanHoDAL.SearchCanHo(mach);
        }

        public static List<CanHoDTO> SearchByGiaMinMax(int min, int max)
        {
            return CanHoDAL.SearchByGiaMinMax(min, max);
        }

        public static List<CanHoDTO> FindEmptyRooms()
        {
            return CanHoDAL.FindEmptyRooms();
        }

        public static bool CheckMaCH(string mach)
        {
            foreach (CanHoDTO spdto in CanHoBLL.GetAllCanHo())
            {
                if (spdto.MaCH.Trim() == mach.Trim())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
