using QLDC.DAL;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.BLL
{
    class DanCuBLL
    {
        public static List<DanCuDTO> GetAllDanCu()
        {
            return DanCuDAL.GetAllDanCu();
        }
        public static bool AddDanCu(DanCuDTO dc)
        {
            return DanCuDAL.AddDanCu(dc);
        }
        public static bool DeleteDanCu(string madc)
        {
            return DanCuDAL.DeleteDanCu(madc);
        }
        public static bool UpdateDC(string madc, DanCuDTO dcdto)
        {
            return DanCuDAL.UpdateDC(madc, dcdto);
        }
        public static DanCuDTO LoadDC(string madc)
        {
            return DanCuDAL.LoadDC(madc);
        }
        public static List<DanCuDTO> SearchDC(string tendc)
        {
            return DanCuDAL.SearchDC(tendc);
        }
        public static bool CheckMaDC(string madc)
        {
            foreach (DanCuDTO spdto in DanCuBLL.GetAllDanCu())
            {
                if (spdto.MaDC.Trim() == madc.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public static List<DanCuDTO> GetDanCuWithMaDV(string madv)
        {
            return DanCuDAL.GetDanCuWithMaDV(madv);
        }

        public static List<DanCuDTO> GetDanCuWithNoDichVu()
        {
            return DanCuDAL.GetDanCuWithNoDichVu();
        }
    }
}
