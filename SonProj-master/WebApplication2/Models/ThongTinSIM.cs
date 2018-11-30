namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSIM")]
    public partial class ThongTinSIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSIM()
        {
            ChiTietSuDungs = new HashSet<ChiTietSuDung>();
            HoaDonDangKies = new HashSet<HoaDonDangKy>();
            HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }

        [Key]
        [StringLength(20)]
        public string IDSIM { get; set; }

        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        [StringLength(20)]
        [Display(Name = "Mã khách hàng")]
        public string MaKH { get; set; }

        [Display(Name = "Ngày đăng ký")]
        public DateTime? NgayDangKy { get; set; }

        [Display(Name = "Ngày hết hạn")]
        public DateTime? NgayHetHan { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
