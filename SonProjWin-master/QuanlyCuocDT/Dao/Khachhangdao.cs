using QuanlyCuocDT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCuocDT.Dao
{
    class Khachhangdao
    {
        QLCuocDTContext db = new QLCuocDTContext();
        public void themkh(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }
        public void suakh(string makh,string tenkh,string cmnd,string nghenghiep,string chucvu,string diachi)
        {
            var kh = db.KhachHangs.Find(makh);
            kh.TenKH = tenkh;
            kh.CMND = cmnd;
            kh.NgheNghiep = nghenghiep;
            kh.ChucVu = chucvu;
            kh.DiaChi = diachi;
            db.SaveChanges();
        }
        
        public string getlastnhanvien()
        {
            var countRow = db.KhachHangs.Count();
            int getCount = countRow + 1;
            string newMaSP = "KH";
            if (getCount < 10) newMaSP += "00" + getCount.ToString();
            else if (getCount < 100) newMaSP += "0" + getCount.ToString();
            return newMaSP;
        }
    }
}
