using System.ComponentModel.DataAnnotations;

namespace HSEPLUS.Models
{
    public class Occupation
    {

        [Key]
        public long id { get; set; }

        [Display(Name = "عنوان سمت")]
        public string? title { get; set; }

        [Display(Name = "کد سمت")]
        public string? occupation_code { get; set; }

        [Display(Name = "نوع سمت")]
        public string? occupation_type { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
