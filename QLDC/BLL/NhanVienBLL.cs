using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDC.DAL;
using QLDC.DAL.EDM;
using QLDC.DTO;

namespace QLDC.BLL
{
    class NhanVienBLL
    {
        public static List<NhanVienDTO> All()
        {
            return NhanVienDAL.All();
        }

        public static NhanVienDTO Get(string maNV)
        {
            return NhanVienDAL.Get(maNV);
        }

        public static bool Insert(NhanVienDTO nv)
        {
            return NhanVienDAL.Insert(nv);
        }

        public static bool Delete(string maNV)
        {
            return NhanVienDAL.Delete(maNV);
        }

        public static bool Update(string maNV, NhanVienDTO nvMoi)
        {
            return NhanVienDAL.Update(maNV, nvMoi);
        }

        public static List<NhanVienDTO> SearchByName(string tenNV)
        {
            return NhanVienDAL.SearchByName(tenNV.Trim());
        }
        public static bool CheckMaNV(string manv)
        {
            foreach (NhanVienDTO spdto in NhanVienDAL.All())
            {
                if (spdto.MaNV.Trim() == manv.Trim())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
