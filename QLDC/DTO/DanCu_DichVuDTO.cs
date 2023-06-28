using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
	public class DanCu_DichVuDTO
	{
		private string _MaDC;
		public string MaDC
		{
			get { return _MaDC; }
			set { _MaDC = value; }
		}

		private string _MaDV;
		public string MaDV
		{
			get { return _MaDV; }
			set { _MaDV = value; }
		}

		private int _TrangThai;
		public int TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}
		public DanCu_DichVuDTO(string MaDC_, string MaDV_, int TrangThai_)
		{
			this.MaDC = MaDC_;
			this.MaDV = MaDV_;
			this.TrangThai = TrangThai_;
		}
		public DanCu_DichVuDTO()
        {
			this.MaDC ="";
			this.MaDV = "";
			this.TrangThai = 0;

		}
	}
}
