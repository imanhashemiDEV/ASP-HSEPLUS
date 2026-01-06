
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace HSEPLUS.Models
{
    public class User
    {
        [Key]
        public BigInteger id;
        
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

    }
}
