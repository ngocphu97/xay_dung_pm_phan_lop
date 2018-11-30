using QuanlyCuocDT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCuocDT.Dao
{
    public class ThongtinSimDao
    {
        public static QLCuocDTContext db = new QLCuocDTContext();
        public void suaidsim(string idsim,string sdt,string makh,DateTime ngaydk,DateTime ngayhethan)
        {
            var a = db.ThongTinSIMs.Find(idsim);
            a.SoDienThoai = sdt;
            a.MaKH = makh;
            a.NgayDangKy = ngaydk;
            a.NgayHetHan = ngayhethan;
            db.SaveChanges();
        }
        public static List<KhachHang> load()
        {
            return db.KhachHangs.Where(p => p.Flag == true).ToList();
        }
        public static string getlastnhanvien()
        {
            var countRow = db.ThongTinSIMs.ToArray().LastOrDefault();
            int idsim = Int32.Parse(countRow.IDSIM) + 1;
            return idsim.ToString();
        }
        public void themidsim(ThongTinSIM ttsim)
        {
            db.ThongTinSIMs.Add(ttsim);
            db.SaveChanges();
        }
    }
}
