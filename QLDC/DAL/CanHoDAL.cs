
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
    internal class CanHoDAL : db
    {
        static Mapper DTO2EntityMapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CanHoDTO, CanHo>()));

        public static List<CanHoDTO> GetALLCanHo()
        {
            return (from ch in data.CanHo
                    where ch.TrangThai == 0
                    select new CanHoDTO
                    {
                        MaCH = (string)ch.MaCH.Trim(),
                        TangLau = (int)ch.TangLau,
                        GiaCH = (int)ch.GiaCH,
                        TrangThai = ch.TrangThai
                    }).ToList();
        }

        public static bool AddcanHo(CanHoDTO ch)
        {
            CanHo dto = DTO2EntityMapper.Map<CanHo>(ch);
            data.CanHo.Add(dto);
            return data.SaveChanges() > 0;
        }

        public static bool DeleteCanHo(string mach)
        {
            CanHo ch = (from c in data.CanHo
                        where c.MaCH.Trim() == mach.Trim()
                        select c).Single<CanHo>();
            ch.TrangThai = 1;
            data.SaveChanges();
            return true;
        }

        public static bool UpdateCanHo(string mach, CanHoDTO chdto)
        {
            CanHo ch = (from c in data.CanHo
                        where c.MaCH.Trim() == mach.Trim()
                        select c).Single<CanHo>();
            ch.TangLau = chdto.TangLau;
            ch.GiaCH = chdto.GiaCH;
            ch.TrangThai = chdto.TrangThai;
            data.SaveChanges();
            return true;
        }

        public static CanHoDTO LoadCanHo(string mach)
        {
            return (from ch in data.CanHo
                    where ch.MaCH.Trim() == mach.Trim()
                    select new CanHoDTO
                    {
                        MaCH = ch.MaCH.Trim(),
                        TangLau = ch.TangLau,
                        GiaCH = (int)ch.GiaCH,
                        TrangThai = ch.TrangThai
                    }).Single<CanHoDTO>();
        }

        public static List<CanHoDTO> SearchCanHo(string mach)
        {
            return (from ch in data.CanHo
                    where ch.MaCH.Contains(mach) && ch.TrangThai == 0
                    select new CanHoDTO
                    {
                        MaCH = ch.MaCH.Trim(),
                        TangLau = ch.TangLau,
                        GiaCH = (int)ch.GiaCH,
                        TrangThai = ch.TrangThai
                    }).ToList();
        }

        public static List<CanHoDTO> SearchByGiaMinMax(int min, int max)
        {
            return (from ch in data.CanHo
                    where ch.GiaCH >= min && ch.GiaCH <= max && ch.TrangThai == 0
                    select new CanHoDTO
                    {
                        MaCH = ch.MaCH.Trim(),
                        TangLau = ch.TangLau,
                        GiaCH = (int)ch.GiaCH,
                        TrangThai = ch.TrangThai
                    }).ToList();
        }

        public static List<CanHoDTO> FindEmptyRooms()
        {
            var all = from ch in data.CanHo
                      where ch.TrangThai == 0
                      select new { ch.MaCH };
            var occupied = from dc in data.DanCu
                           where dc.TrangThai == 0
                           select new { dc.MaCH };
            var empty = all.Except(occupied);

            return (from ch in data.CanHo
                    from ep in empty
                    where ch.MaCH == ep.MaCH
                    select new CanHoDTO
                    {
                        MaCH = ch.MaCH.Trim(),
                        TangLau = ch.TangLau,
                        GiaCH = (int)ch.GiaCH,
                        TrangThai = ch.TrangThai
                    }).ToList();
        }
    }
}
