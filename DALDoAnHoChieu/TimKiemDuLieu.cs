using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALDoAnHoChieu
{
   public class TimKiemDuLieu
    {
        HoChieuModelDataContext hoChieuModelDataContext;
        public TimKiemDuLieu()
        {
            hoChieuModelDataContext= new HoChieuModelDataContext();
        }
        public List<DangKyHoChieu> TimKiemMaHoChieu(int maHoChieu)
        {
            return (from DangKyHoChieu in hoChieuModelDataContext.DangKyHoChieus where DangKyHoChieu.MaDangKyMoi==maHoChieu select DangKyHoChieu).ToList();
        }
        public List<HoChieu> TimKiemMaCapHoChieu(int maHoChieu)
        {
            return (from HoChieu in hoChieuModelDataContext.HoChieus where HoChieu.MaDangKy == maHoChieu select HoChieu).ToList();
        }
        public List<GioiTinh> TimKiemGioiTinh(int maGioiTinh)
        {
            return (from GioiTinh in hoChieuModelDataContext.GioiTinhs where GioiTinh.MaGioiTinh == maGioiTinh select GioiTinh).ToList();
        }
        public List<QuocGia> TimKiemQuocGia(String maQuocGia)
        {
            return (from QuocGia in hoChieuModelDataContext.QuocGias where QuocGia.MaQuocGia == maQuocGia select QuocGia).ToList();
        }
        public List<Tinh> TimKiemTinh(int maTinh)
        {
            return (from Tinh in hoChieuModelDataContext.Tinhs where Tinh.MaTinh == maTinh select Tinh).ToList();
        }
        public List<Quan> TimKiemQuan(int maQuan)
        {
            return (from Quan in hoChieuModelDataContext.Quans where Quan.MaQuan == maQuan select Quan).ToList();
        }
        public List<Phuong> TimKiemPhuong(int maPhuong)
        {
            return (from Phuong in hoChieuModelDataContext.Phuongs where Phuong.MaPhuong == maPhuong select Phuong).ToList();
        }
        public List<TonGiao> TimKiemTonGiao(int maTonGiao)
        {
            return (from TonGiao in hoChieuModelDataContext.TonGiaos where TonGiao.MaTonGiao == maTonGiao select TonGiao).ToList();
        }
        public List<DanToc> TimKiemDanToc(int maDanToc)
        {
            return (from DanToc in hoChieuModelDataContext.DanTocs where DanToc.MaDanToc == maDanToc select DanToc).ToList();
        }
        public List<NgheNghiep> TimKiemNgheNghiep(int maNgheNghiep)
        {
            return (from NgheNghiep in hoChieuModelDataContext.NgheNghieps where NgheNghiep.MaNgheNghiep == maNgheNghiep select NgheNghiep).ToList();
        }

    }
}
