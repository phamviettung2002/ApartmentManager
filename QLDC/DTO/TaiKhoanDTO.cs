using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDC.DTO
{
    public class TaiKhoanDTO
    {
        private string _MaTK;
        public string MaTK
        {
            get { return _MaTK; }
            set { _MaTK = value; }
        }

        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }


        public TaiKhoanDTO(string MaTK_, string MatKhau_)
        {
            this.MaTK = MaTK_;
            this.MatKhau = MatKhau_;
        }

        public TaiKhoanDTO()
        {
            this.MaTK = "";
            this.MatKhau = "";
        }
    }
}
