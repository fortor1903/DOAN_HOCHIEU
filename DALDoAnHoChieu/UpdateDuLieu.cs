using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
    public class UpdateDuLieu
    {
        HoChieuModelDataContext hoChieuModelDataContext;
        public UpdateDuLieu()
        {
            hoChieuModelDataContext = new HoChieuModelDataContext();
        }
        public void CapNhatTrangThai(DangKyHoChieu user)
        {
            DangKyHoChieu nUser = hoChieuModelDataContext.DangKyHoChieus.Single(u => u.MaDangKyMoi == user.MaDangKyMoi);
            nUser = user;
            hoChieuModelDataContext.SubmitChanges();       
        }
    }
}
