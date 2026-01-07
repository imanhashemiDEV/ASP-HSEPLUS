using System.ComponentModel.DataAnnotations;

namespace HSEPLUS.Models
{
    public class User
    {
        [Key]
        public long id { get; set; }
        
        [Display(Name = "نام و نام خانوادگی")]
        public string? name { get; set; }

        [Display(Name = "موبایل")]
        public string? mobile { get; set; }

        [Display(Name = "رمز عبور")]
        public string? password { get; set; }
        
        [Display(Name = "شماره پرسنلی")]
        public string? register_code { get; set; }

        [Display(Name = "کد ملی")]
        public string? national_code { get; set; }
        
        [Display(Name = "عکس پروفایل")]
        public string? image { get; set; }

        [Display(Name = "نوع استخدام")]
        public string? employment_type { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
