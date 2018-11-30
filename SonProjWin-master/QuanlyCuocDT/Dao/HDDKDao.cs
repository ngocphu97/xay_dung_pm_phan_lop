using QuanlyCuocDT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCuocDT.Dao
{
    class HDDKDao
    {
        QLCuocDTContext db = new QLCuocDTContext();
        public void suahddk(string mahd,string idsim)
        {
            var a = db.HoaDonDangKies.Find(mahd);
            a.IDSIM = idsim;
            db.SaveChanges();
        }
        public List<ThongTinSIM> load()
        {
            return db.ThongTinSIMs.ToList();
        }
        public string getlastnhanvien()
        {
            var countRow = db.HoaDonDangKies.Count();
            int getCount = countRow + 1;
            string newMaSP = "HDDK";
            if (getCount < 10) newMaSP += "00" + getCount.ToString();
            else if (getCount < 100) newMaSP += "0" + getCount.ToString();
            return newMaSP;
        }
        public void themhd(HoaDonDangKy hddk)
        {
            db.HoaDonDangKies.Add(hddk);
            db.SaveChanges();
        }
    }
}
