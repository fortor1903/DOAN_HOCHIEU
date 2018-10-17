using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
    class DangKyHoCieuss
    {
        String hoten, email, sonhathuongtru, sonhatamtru, tencoquan, diachicoquan, hotencha, hotenme, hotenvochong;
        int gioitinh, quocgianoisinh, tinh, cmnd, noicap, dantoc, tongiao, sdt, tinhthuongtru, quanthuongtru, phuongthuongtru, tinhtamtru, quantamtru, phuongtamtru, nghenghiep;
        DateTime ngaysinh, ngaycap, ngaysinhcha, ngaysinhme, ngaysinhvochong;
        public DangKyHoCieuss()
        {
            this.hoten = Hoten;
            this.email = Email;
            this.sonhatamtru = Sonhatamtru;
            this.sonhathuongtru = Sonhathuongtru;
            this.tencoquan = Tencoquan;
            this.diachicoquan = Diachicoquan;
            this.hotencha = Hotencha;
            this.hotenme = Hotenme;
            this.hotenvochong = Hotenvochong;
            this.gioitinh = Gioitinh;
            this.quocgianoisinh = Quocgianoisinh;
            this.tinh = Tinh;
            this.cmnd = Cmnd;
            this.noicap = Noicap;
            this.tongiao = Tongiao;
            this.sdt = Sdt;
            this.tinhthuongtru = Tinhthuongtru;
            this.tinhtamtru = Tinhtamtru;
            this.quantamtru = Quantamtru;
            this.quanthuongtru = Quanthuongtru;
            this.phuongtamtru = Phuongtamtru;
            this.phuongthuongtru = Phuongthuongtru;
            this.nghenghiep = Nghenghiep;
            this.ngaycap = Ngaycap;
            this.ngaysinh = Ngaysinh;
            this.ngaysinhcha = Ngaysinhcha;
            this.ngaysinhme = Ngaysinhme;
            this.ngaysinhvochong = Ngaysinhvochong;
        }
        public DangKyHoCieuss(DangKyHoCieuss tt)
        {
            tt.hoten = Hoten;
            tt.email = Email;
            tt.sonhatamtru = Sonhatamtru;
            tt.sonhathuongtru = Sonhathuongtru;
            tt.tencoquan = Tencoquan;
            tt.diachicoquan = Diachicoquan;
            tt.hotencha = Hotencha;
            tt.hotenme = Hotenme;
            tt.hotenvochong = Hotenvochong;
            tt.gioitinh = Gioitinh;
            tt.quocgianoisinh = Quocgianoisinh;
            tt.tinh = Tinh;
            tt.cmnd = Cmnd;
            tt.noicap = Noicap;
            tt.tongiao = Tongiao;
            tt.sdt = Sdt;
            tt.tinhthuongtru = Tinhthuongtru;
            tt.tinhtamtru = Tinhtamtru;
            tt.quantamtru = Quantamtru;
            tt.quanthuongtru = Quanthuongtru;
            tt.phuongtamtru = Phuongtamtru;
            tt.phuongthuongtru = Phuongthuongtru;
            tt.nghenghiep = Nghenghiep;
            tt.ngaycap = Ngaycap;
            tt.ngaysinh = Ngaysinh;
            tt.ngaysinhcha = Ngaysinhcha;
            tt.ngaysinhme = Ngaysinhme;
            tt.ngaysinhvochong = Ngaysinhvochong;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Sonhathuongtru { get => sonhathuongtru; set => sonhathuongtru = value; }
        public string Sonhatamtru { get => sonhatamtru; set => sonhatamtru = value; }
        public string Tencoquan { get => tencoquan; set => tencoquan = value; }
        public string Diachicoquan { get => diachicoquan; set => diachicoquan = value; }
        public string Hotencha { get => hotencha; set => hotencha = value; }
        public string Hotenme { get => hotenme; set => hotenme = value; }
        public string Hotenvochong { get => hotenvochong; set => hotenvochong = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Quocgianoisinh { get => quocgianoisinh; set => quocgianoisinh = value; }
        public int Tinh { get => tinh; set => tinh = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public int Noicap { get => noicap; set => noicap = value; }
        public int Dantoc { get => dantoc; set => dantoc = value; }
        public int Tongiao { get => tongiao; set => tongiao = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int Tinhthuongtru { get => tinhthuongtru; set => tinhthuongtru = value; }
        public int Quanthuongtru { get => quanthuongtru; set => quanthuongtru = value; }
        public int Phuongthuongtru { get => phuongthuongtru; set => phuongthuongtru = value; }
        public int Tinhtamtru { get => tinhtamtru; set => tinhtamtru = value; }
        public int Quantamtru { get => quantamtru; set => quantamtru = value; }
        public int Phuongtamtru { get => phuongtamtru; set => phuongtamtru = value; }
        public int Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DateTime Ngaycap { get => ngaycap; set => ngaycap = value; }
        public DateTime Ngaysinhcha { get => ngaysinhcha; set => ngaysinhcha = value; }
        public DateTime Ngaysinhme { get => ngaysinhme; set => ngaysinhme = value; }
        public DateTime Ngaysinhvochong { get => ngaysinhvochong; set => ngaysinhvochong = value; }
    }
}
