using QLDC.DAL;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.BLL
{
    class DichVuBLL
    {
        public static List<DichVuDTO> GetAllDichVu()
        {
            return DichVuDAL.GetALLDichVu();
        }
        public static bool AddDichVu(DichVuDTO dv)
        {
            return DichVuDAL.AddDichVu(dv);
        }
        public static bool DeleteDichVu(string madv)
        {
            return DichVuDAL.DeleteDichVu(madv);
        }
        public static bool UpdateDichVu(string madv,DichVuDTO dvdto)
        {
            return DichVuDAL.UpdateDichVu(madv, dvdto);
        }
        public static List<DichVuDTO> GetDichVuWithMaDC(string madc)
        {
            return DichVuDAL.GetDichVuWithMaDC(madc);
        }

        public static List<DichVuDTO> GetByMaDC(string maDC)
        {
            return DichVuDAL.GetByMaDC(maDC.Trim());
        }
        public static List<DichVuDTO> SearchDichVu(string madv)
        {
            return DichVuDAL.SearchDichVu(madv);
        }
        public static bool CheckMaDV(string madv)
        {
            foreach (DichVuDTO spdto in  DichVuDAL.GetALLDichVu())
            {
                if (spdto.MaDV.Trim() == madv.Trim())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
