using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
	public class CanHoDTO
	{
		private string _MaCH;
		public string MaCH
		{
			get { return _MaCH; }
			set { _MaCH = value; }
		}

		private int _TangLau;
		public int TangLau
		{
			get { return _TangLau; }
			set { _TangLau = value; }
		}

		private int _GiaCH;
		public int GiaCH
		{
			get { return _GiaCH; }
			set { _GiaCH = value; }
		}
		private int _TrangThai;
		public int TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}
		public CanHoDTO(string MaCH_, int TangLau_, int GiaCH_, int TrangThai_)
		{
			this.MaCH = MaCH_;
			this.TangLau = TangLau_;
			this.GiaCH = GiaCH_;
			this.TrangThai = TrangThai_;
		}
		public CanHoDTO()
        {
			this.MaCH = "";
			this.TangLau = 0;
			this.GiaCH = 0;
			this.TrangThai = 0;

		}
	}
}
