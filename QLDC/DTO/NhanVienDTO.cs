using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
	public class NhanVienDTO
	{
		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _TenNV;
		public string TenNV
		{
			get { return _TenNV; }
			set { _TenNV = value; }
		}

		private string _GioiTinh;
		public string GioiTinh
		{
			get { return _GioiTinh; }
			set { _GioiTinh = value; }
		}

		private DateTime _NgaySinh;
		public DateTime NgaySinh
		{
			get { return _NgaySinh; }
			set { _NgaySinh = value; }
		}

		private string _DienThoai;
		public string DienThoai
		{
			get { return _DienThoai; }
			set { _DienThoai = value; }
		}

		private string _ChucVu;
		public string ChucVu
		{
			get { return _ChucVu; }
			set { _ChucVu = value; }
		}

		private int _TrangThai;
		public int TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}
		public NhanVienDTO(string MaNV_, string TenNV_, string GioiTinh_, DateTime NgaySinh_, string DienThoai_, string ChucVu_, int TrangThai_)
		{
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.GioiTinh = GioiTinh_;
			this.NgaySinh = NgaySinh_;
			this.DienThoai = DienThoai_;
			this.ChucVu = ChucVu_;
			this.TrangThai = TrangThai_;
		}
		public NhanVienDTO()
        {
			this.MaNV = "";
			this.TenNV = "";
			this.GioiTinh = "";
			this.NgaySinh = new DateTime();
			this.DienThoai = "";
			this.ChucVu = "";
			this.TrangThai = 0;

		}
	}
}
