using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
    public class LayDuLieu

    {
        HoChieuModelDataContext hoChieuModelDataContext;
        public LayDuLieu()
        {
            hoChieuModelDataContext = new HoChieuModelDataContext();
        }

        public List<Tinh>  LayDanhSachTinh()
        {
            List<Tinh> tinhs = (from Tinh in hoChieuModelDataContext.Tinhs select Tinh).ToList();
            return tinhs;
        }
        public List<DanToc> LayDanhSachDanToc()
        {
            return (from DanToc in hoChieuModelDataContext.DanTocs select DanToc).ToList();
        }
        public List<Phuong> LayDanhSachPhuong()
        {
            return (from Phuong in hoChieuModelDataContext.Phuongs select Phuong).ToList();
        }
        public List<Quan> LayDanhSachQuan()
        {
            return (from Quan in hoChieuModelDataContext.Quans select Quan).ToList();
        }
        public List<QuocGia> LayDanhSachQuocGia()
        {
            return (from QuocGia in hoChieuModelDataContext.QuocGias select QuocGia).ToList();
        }
        public List<GioiTinh> LayDanhSachGioiTinh()
        {
            return (from GioiTinh in hoChieuModelDataContext.GioiTinhs select GioiTinh).ToList();
        }
        public List<TonGiao> LayDanhSachTonGiao()
        {
            return (from TonGiao in hoChieuModelDataContext.TonGiaos select TonGiao).ToList();
        }
        public List<NgheNghiep> LayDanhSachNgheNghiep()
        {
             return (from NgheNghiep in hoChieuModelDataContext.NgheNghieps select NgheNghiep).ToList();
        }
        public List<DangKyHoChieu> LayDanhSachHoChieu()
        {
            return (from DangKyHoChieu in hoChieuModelDataContext.DangKyHoChieus select DangKyHoChieu).ToList();
        }
        public List<HoChieu> LayDanhSachCapHoChieu()
        {
            return (from HoChieu in hoChieuModelDataContext.HoChieus select HoChieu).ToList();
        }
    }
}
