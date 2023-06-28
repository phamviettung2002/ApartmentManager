using AutoMapper;
using QLDC.DAL.EDM;
using QLDC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DAL
{
    internal class DichVuDAL:db
    {
        static Mapper DTO2EntityMapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DichVuDTO, DichVu>()));

        public static List<DichVuDTO> GetALLDichVu()
        {
            return (from dv in data.DichVu
                    where dv.TrangThai == 0
                    select new DichVuDTO
                    {
                        MaDV = dv.MaDV.Trim(),
                        TenDV = dv.TenDV.Trim(),
                        DonGia = dv.DonGia,
                        TrangThai = dv.TrangThai
                    }).ToList();
        }

        public static bool AddDichVu(DichVuDTO dv)
        {
            DichVu dto = DTO2EntityMapper.Map<DichVu>(dv);
            data.DichVu.Add(dto);
            return data.SaveChanges() > 0;
        }

        public static bool DeleteDichVu(string madv)
        {
            DichVu dv = (from d in data.DichVu
                         where d.MaDV.Trim() == madv.Trim()
                         select d).Single<DichVu>();
            dv.TrangThai = 1;
            return data.SaveChanges() > 0;
        }
        public static bool UpdateDichVu(string madv, DichVuDTO dto)
        {
            DichVu dv = (from d in data.DichVu
                         where d.MaDV.Trim() == madv.Trim()
                         select d).Single<DichVu>();
            dv.TenDV = dto.TenDV.Trim();
            dv.DonGia = dto.DonGia;
            return data.SaveChanges() > 0;
        }

        public static List<DichVuDTO> GetDichVuWithMaDC(string madc)
        {
            return (from dv in data.DichVu
                         join dc_dv in data.DanCu_DichVu on dv.MaDV equals dc_dv.MaDV
                         where dc_dv.MaDC.Trim() == madc.Trim() && dc_dv.TrangThai==0
                         select new DichVuDTO
                         {
                             MaDV = dv.MaDV.Trim(),
                             TenDV = dv.TenDV.Trim(),
                             DonGia = dv.DonGia,
                             TrangThai = dv.TrangThai
                         }).ToList();           
        }
        public static List<DichVuDTO> GetByMaDC(string maDC)
        {
            return (from dcdv in data.DanCu_DichVu
                    join dv in data.DichVu on dcdv.MaDV equals dv.MaDV
                    where dcdv.MaDC == maDC && dcdv.TrangThai == 0
                    select new DichVuDTO
                    {
                        MaDV = dv.MaDV.Trim(),
                        TenDV = dv.TenDV.Trim(),
                        DonGia = dv.DonGia,
                        TrangThai = dv.TrangThai
                    }).ToList();
        }

        public static List<DichVuDTO> SearchDichVu(string tenDV)
        {
            return (from dv in data.DichVu
                    where dv.TenDV.Contains(tenDV) && dv.TrangThai == 0
                    select new DichVuDTO
                    {
                        MaDV = dv.MaDV.Trim(),
                        TenDV = dv.TenDV.Trim(),
                        DonGia = dv.DonGia,
                        TrangThai = dv.TrangThai
                    }).ToList();
        }
    }
}
