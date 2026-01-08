using System.ComponentModel.DataAnnotations;

namespace HSEPLUS.Models
{
    public class Organization
    {

        [Key]
        public long id { get; set; }

        [Display(Name = "عنوان شرکت")]
        public string? title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;
    }
}
