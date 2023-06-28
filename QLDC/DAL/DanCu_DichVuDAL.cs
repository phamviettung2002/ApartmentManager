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
    internal class DanCu_DichVuDAL : db
    {
        static Mapper DTO2EntityMapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DanCu_DichVuDTO, DanCu_DichVu>()));

        public static List<DanCu_DichVuDTO> GetAllDC_DV()
        {
            return (from dc_dv in data.DanCu_DichVu
                    where dc_dv.TrangThai == 0
                    select new DanCu_DichVuDTO
                    {
                        MaDC = dc_dv.MaDC.Trim(),
                        MaDV = dc_dv.MaDV.Trim()
                    }).ToList();
        }

        public static bool AddDC_DV(DanCu_DichVuDTO dc_dv)
        {
            DanCu_DichVu dto = DTO2EntityMapper.Map<DanCu_DichVu>(dc_dv);
            data.DanCu_DichVu.Add(dto);
            return data.SaveChanges() > 0;
        }

        public static bool DeleteDC_DV(string maDC, string maDV)
        {
            DanCu_DichVu dc_dv = (from d in data.DanCu_DichVu
                                  where d.MaDC.Trim() == maDC.Trim() && d.MaDV.Trim() == maDV.Trim()
                                  select d).Single<DanCu_DichVu>();
            dc_dv.TrangThai = 1;
            return data.SaveChanges() > 0;
        }

        public static bool UpdateDC_DV(string maDC, DanCu_DichVuDTO dto)
        {
            DanCu_DichVu dcdvEntity = (from dcdv in data.DanCu_DichVu
                                       where dcdv.MaDC.Trim() == maDC.Trim()
                                       select dcdv).Single<DanCu_DichVu>();
            dcdvEntity.MaDC = dcdvEntity.MaDC.Trim();
            dcdvEntity.MaDV = dcdvEntity.MaDV.Trim();
            return data.SaveChanges() > 0;
        }

        public static DanCu_DichVuDTO LoadDC_DV(string madc)
        {
            return (from dc_dv in data.DanCu_DichVu
                    where dc_dv.MaDC.Trim() == madc.Trim()
                    select new DanCu_DichVuDTO
                    {
                        MaDC = dc_dv.MaDC.Trim(),
                        MaDV = dc_dv.MaDV.Trim()
                    }).Single<DanCu_DichVuDTO>();
        }

        public static List<DanCu_DichVuDTO> SearchDC_DV(string maDC)
        {
            return (from dc_dv in data.DanCu_DichVu
                    where dc_dv.TrangThai == 0 && dc_dv.MaDC.StartsWith(maDC)
                    select new DanCu_DichVuDTO
                    {
                        MaDC = dc_dv.MaDC.Trim(),
                        MaDV = dc_dv.MaDV.Trim()
                    }).ToList();
        }
        public static List<DanCu_DichVuDTO> SearchDV(string madv)
        {
            return (from dc_dv in data.DanCu_DichVu
                    where dc_dv.TrangThai == 0 && dc_dv.MaDV.StartsWith(madv)
                    select new DanCu_DichVuDTO
                    {
                        MaDC = dc_dv.MaDC.Trim(),
                        MaDV = dc_dv.MaDV.Trim()
                    }).ToList();
        }
    }
}
