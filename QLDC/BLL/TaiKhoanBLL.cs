using QLDC.DAL;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.BLL
{
    class TaiKhoanBLL
    {
        public static List<TaiKhoanDTO> All()
        {
            return TaiKhoanDAL.All();
        }
        public static bool Insert(string maTK, string mk)
        {
            return TaiKhoanDAL.Insert(maTK.Trim(), mk.Trim());
        }

        public static TaiKhoanDTO Get(string maTK)
        {
            return TaiKhoanDAL.Get(maTK);
        }

        public static bool Authenticate(string maTK, string mk)
        {
            return TaiKhoanDAL.Authenticate(maTK, mk);
        }
    }
}
