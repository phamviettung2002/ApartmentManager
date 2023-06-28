using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using QLDC.DAL.EDM;
using QLDC.DTO;

namespace QLDC.DAL
{
    internal class NhanVienDAL : db
    {
        static Mapper DTO2EntityMapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<NhanVienDTO, NhanVien>()));

        public static List<NhanVienDTO> All()
        {
            return (from nv in data.NhanVien
                    where nv.TrangThai == 0
                    select new NhanVienDTO
                    {
                        MaNV = nv.MaNV.Trim(),
                        TenNV = nv.TenNV.Trim(),
                        GioiTinh = nv.GioiTinh.Trim(),
                        NgaySinh = nv.NgaySinh,
                        DienThoai = nv.DienThoai.Trim(),
                        ChucVu = nv.ChucVu.Trim(),
                        TrangThai = nv.TrangThai
                    }).ToList();
        }

        private static NhanVien GetEntity(string maNV)
        {
            return (from nhanvien in data.NhanVien
                    where nhanvien.MaNV.Trim() == maNV.Trim()
                    select nhanvien).Single<NhanVien>();
        }

        public static NhanVienDTO Get(string maNV)
        {
            return (from nv in data.NhanVien
                    where nv.MaNV.Trim() == maNV.Trim()
                    select new NhanVienDTO
                    {
                        MaNV = nv.MaNV.Trim(),
                        TenNV = nv.TenNV.Trim(),
                        GioiTinh = nv.GioiTinh.Trim(),
                        NgaySinh = nv.NgaySinh,
                        DienThoai = nv.DienThoai.Trim(),
                        ChucVu = nv.ChucVu.Trim(),
                        TrangThai = nv.TrangThai
                    }).Single<NhanVienDTO>();
        }

        public static bool Insert(NhanVienDTO nv)
        {
            data.NhanVien.Add((DTO2EntityMapper.Map<NhanVien>(nv)));
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string maNV)
        {
            var res = GetEntity(maNV);
            res.TrangThai = 1;
            return data.SaveChanges() > 0;
        }

        public static bool Update(string maNV, NhanVienDTO nvMoi)
        {
            NhanVien nv = GetEntity(maNV);
            nv.TenNV = nvMoi.TenNV;
            nv.GioiTinh = nvMoi.GioiTinh;
            nv.DienThoai = nvMoi.DienThoai;
            nv.ChucVu = nvMoi.ChucVu;
            nv.TrangThai = nvMoi.TrangThai;

            return data.SaveChanges() > 0;
        }

        public static List<NhanVienDTO> SearchByName(string tenNV)
        {
            return (from nv in data.NhanVien
                    where nv.TenNV.Contains(tenNV) && nv.TrangThai == 0
                    select new NhanVienDTO
                    {
                        MaNV = nv.MaNV.Trim(),
                        TenNV = nv.TenNV.Trim(),
                        GioiTinh = nv.GioiTinh.Trim(),
                        NgaySinh = nv.NgaySinh,
                        DienThoai = nv.DienThoai.Trim(),
                        ChucVu = nv.ChucVu.Trim(),
                        TrangThai = nv.TrangThai
                    }).ToList();
        }
    }
}
