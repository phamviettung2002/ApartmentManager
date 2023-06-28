
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
    internal class DanCuDAL : db
    {
        static Mapper DTO2EntityMapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DanCuDTO, DanCu>()));

        public static List<DanCuDTO> GetAllDanCu()
        {
            return (from dc in data.DanCu
                    where dc.TrangThai == 0
                    select new DanCuDTO
                    {
                        MaDC = dc.MaDC.Trim(),
                        TenDC = dc.TenDC.Trim(),
                        GioiTinh = dc.GioiTinh.Trim(),
                        NgaySinh = dc.NgaySinh,
                        QueQuan = dc.QueQuan.Trim(),
                        MaCH = dc.MaCH.Trim(),
                        TrangThai = dc.TrangThai
                    }).ToList();
        }

        public static bool AddDanCu(DanCuDTO dc)
        {
            DanCu dto = DTO2EntityMapper.Map<DanCu>(dc);
            data.DanCu.Add(dto);
            return data.SaveChanges() > 0;
        }

        public static bool DeleteDanCu(string madc)
        {
            DanCu dc = (from d in data.DanCu
                        where d.MaDC.Trim() == madc.Trim()
                        select d).Single<DanCu>();
            dc.TrangThai = 1;
            return data.SaveChanges() > 0;
        }

        public static bool UpdateDC(string madc, DanCuDTO dcdto)
        {
            DanCu dc = (from d in data.DanCu
                        where d.MaDC.Trim() == madc.Trim()
                        select d).Single<DanCu>();
            dc.TenDC = dcdto.TenDC.Trim();
            dc.GioiTinh = dcdto.GioiTinh.Trim();
            dc.NgaySinh = dcdto.NgaySinh;
            dc.QueQuan = dcdto.QueQuan.Trim();
            dc.MaCH = dcdto.MaCH.Trim();
            return data.SaveChanges() > 0;
        }

        public static DanCuDTO LoadDC(string madc)
        {
            return (from dc in data.DanCu
                    where dc.MaDC.Trim() == madc.Trim()
                    select new DanCuDTO
                    {
                        MaDC = dc.MaDC.Trim(),
                        TenDC = dc.TenDC.Trim(),
                        GioiTinh = dc.GioiTinh.Trim(),
                        NgaySinh = dc.NgaySinh,
                        QueQuan = dc.QueQuan.Trim(),
                        MaCH = dc.MaCH.Trim(),
                        TrangThai = dc.TrangThai
                    }).Single<DanCuDTO>();
        }

        public static List<DanCuDTO> SearchDC(string tendc)
        {
            return (from dc in data.DanCu
                    where dc.TenDC.Trim().Contains(tendc) && dc.TrangThai == 0
                    select new DanCuDTO
                    {
                        MaDC = dc.MaDC.Trim(),
                        TenDC = dc.TenDC.Trim(),
                        GioiTinh = dc.GioiTinh.Trim(),
                        NgaySinh = dc.NgaySinh,
                        QueQuan = dc.QueQuan.Trim(),
                        MaCH = dc.MaCH.Trim(),
                        TrangThai = dc.TrangThai
                    }).ToList();
        }
        public static List<DanCuDTO> GetDanCuWithMaDV(string madv)
        {
            return (from dv in data.DanCu
                    join dc_dv in data.DanCu_DichVu on dv.MaDC equals dc_dv.MaDC
                    where dc_dv.MaDV.Trim() == madv.Trim() && dc_dv.TrangThai == 0
                    select new DanCuDTO
                    {
                        MaDC = dv.MaDC.Trim(),
                        TenDC = dv.TenDC.Trim(),
                        GioiTinh = dv.GioiTinh,
                        NgaySinh = dv.NgaySinh,
                        QueQuan = dv.QueQuan,
                        TrangThai = dv.TrangThai
                    }).ToList();
        }

        public static List<DanCuDTO> GetDanCuWithNoDichVu()
        {
            var all = from dc in data.DanCu
                      where dc.TrangThai == 0
                      select new { dc.MaDC };
            var registered = from dc in data.DanCu_DichVu
                             where dc.TrangThai == 0
                             select new { dc.MaDC };
            var unregistered = all.Except(registered);

            return (from dc in data.DanCu
                    from unreg in unregistered
                    where dc.MaDC == unreg.MaDC
                    select new DanCuDTO
                    {
                        MaDC = dc.MaDC.Trim(),
                        TenDC = dc.TenDC.Trim(),
                        GioiTinh = dc.GioiTinh.Trim(),
                        NgaySinh = dc.NgaySinh,
                        QueQuan = dc.QueQuan.Trim(),
                        MaCH = dc.MaCH.Trim(),
                        TrangThai = dc.TrangThai
                    }).ToList();
        }
    }
}
