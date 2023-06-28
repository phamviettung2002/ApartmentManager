using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
	public class DichVuDTO
	{
		private string _MaDV;
		public string MaDV
		{
			get { return _MaDV; }
			set { _MaDV = value; }
		}

		private string _TenDV;
		public string TenDV
		{
			get { return _TenDV; }
			set { _TenDV = value; }
		}

		private int _DonGia;
		public int DonGia
		{
			get { return _DonGia; }
			set { _DonGia = value; }
		}

		private int _TrangThai;
		public int TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public DichVuDTO(string MaDV_, string TenDV_, int DonGia_, int TrangThai_)
		{
			this.MaDV = MaDV_;
			this.TenDV = TenDV_;
			this.DonGia = DonGia_;
			this.TrangThai = TrangThai_;
		}
		public DichVuDTO()
        {
			this.MaDV = "";
			this.TenDV = "";
			this.DonGia = 0;
			this.TrangThai = 0;

		}
	}
}
