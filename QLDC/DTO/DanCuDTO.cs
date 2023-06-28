using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
    public class DanCuDTO
    {
        private string _MaDC;
        public string MaDC
        {
            get { return _MaDC; }
            set { _MaDC = value; }
        }

        private string _TenDC;
        public string TenDC
        {
            get { return _TenDC; }
            set { _TenDC = value; }
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

        private string _QueQuan;
        public string QueQuan
        {
            get { return _QueQuan; }
            set { _QueQuan = value; }
        }

        private string _MaCH;
        public string MaCH
        {
            get { return _MaCH; }
            set { _MaCH = value; }
        }

        private int _TrangThai;
        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        public DanCuDTO(string MaDC_, string TenDC_, string GioiTinh_, DateTime NgaySinh_, string QueQuan_, string MaCH_, int TrangThai_)
        {
            this.MaDC = MaDC_;
            this.TenDC = TenDC_;
            this.GioiTinh = GioiTinh_;
            this.NgaySinh = NgaySinh_;
            this.QueQuan = QueQuan_;
            this.MaCH = MaCH_;
            this.TrangThai = TrangThai_;
        }
        public DanCuDTO()
        {
            this.MaDC = "";
            this.TenDC = "";
            this.GioiTinh = "";
            this.NgaySinh = new DateTime();
            this.QueQuan = "";
            this.MaCH = "";
            this.TrangThai = 0;
        }
    }
}
