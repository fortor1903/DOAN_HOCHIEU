using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
   public class ThongTinUserDAL
    {
       public bool CheckUserInfor(string pTenDangNhap, string pMatKhau)
       {
           //Khai bao bien ketQua
           bool ketQua = false;

           HoChieuModelDataContext ct = new HoChieuModelDataContext();
           TaiKhoan user = (from u in ct.TaiKhoans where u.MatKhau == pMatKhau && u.TenTaiKhoan == pTenDangNhap select u).FirstOrDefault();
           
           //Kiem tra thong tin hop le
           if (user != null)
               ketQua = true;
           else 
               ketQua = false;
           return ketQua;
       }
    }
}
