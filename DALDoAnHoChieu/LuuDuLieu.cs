using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
    public class LuuDuLieu
    {
        HoChieuModelDataContext hoChieuModelDataContext;
        public LuuDuLieu() {
            hoChieuModelDataContext = new HoChieuModelDataContext();
        }
        public void LuuHSDangKy(DangKyHoChieu tt)
        {            
            hoChieuModelDataContext.DangKyHoChieus.InsertOnSubmit(tt);
            hoChieuModelDataContext.SubmitChanges();
        }
        public void LuuHoChieu(HoChieu tt)
        {
            hoChieuModelDataContext.HoChieus.InsertOnSubmit(tt);
            hoChieuModelDataContext.SubmitChanges();
        }
    }
}
