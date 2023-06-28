using QLDC.DAL.EDM;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using AutoMapper;

namespace QLDC.DAL
{
    class TaiKhoanDAL : db
    {
        private static Mapper mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TaiKhoan, TaiKhoanDTO>()));

        private static string MD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            md5.Dispose();

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static List<TaiKhoanDTO> All()
        {
            var res = from tk in data.TaiKhoan
                      select tk;

            List<TaiKhoanDTO> listTK = new List<TaiKhoanDTO>();
            foreach (TaiKhoan tk in res)
            {
                listTK.Add(mapper.Map<TaiKhoanDTO>(tk));
            }
            return listTK;
        }

        public static bool Insert(string maTK, string mk)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MaTK = maTK;
            tk.MatKhau = MD5Hash(mk);
            data.TaiKhoan.Add(tk);
            return data.SaveChanges() > 0;
        }

        public static TaiKhoanDTO Get(string maTK)
        {
            var res = (from tk in data.TaiKhoan
                       where tk.MaTK == maTK
                       select tk).Single<TaiKhoan>();
            return mapper.Map<TaiKhoanDTO>(res);
        }

        public static bool Authenticate(string maTK, string mk)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            try
            {
                tk = Get(maTK);
            }
            catch
            {
                return false;
            }
            return tk.MatKhau == MD5Hash(mk);
        }
    }
}
