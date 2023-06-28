using QLDC.DAL;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.BLL
{
    class DanCu_DichVuBLL
    {
        public static List<DanCu_DichVuDTO> GetAllDC_DV()
        {
            return DanCu_DichVuDAL.GetAllDC_DV();
        }
        public static bool AddDC_DV(DanCu_DichVuDTO dc_dv)
        {
            return DanCu_DichVuDAL.AddDC_DV(dc_dv);
        }
        public static bool DeleteDC_DV(string maDC, string maDV)
        {
            return DanCu_DichVuDAL.DeleteDC_DV(maDC, maDV);
        }
        public static bool UpdateDC_DV(string madc, DanCu_DichVuDTO dcdvdto)
        {
            return DanCu_DichVuDAL.UpdateDC_DV(madc, dcdvdto);
        }
        public static DanCu_DichVuDTO LoadDC_DV(string madc)
        {
            return DanCu_DichVuDAL.LoadDC_DV(madc);
        }
        public static List<DanCu_DichVuDTO> SearchDC_DV(string madc)
        {
            return DanCu_DichVuDAL.SearchDC_DV(madc);
        }
        public static List<DanCu_DichVuDTO> SearchDV(string madv)
        {
            return DanCu_DichVuDAL.SearchDV(madv);
        }
    }
}
