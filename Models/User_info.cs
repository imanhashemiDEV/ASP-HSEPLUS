using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSEPLUS.Models
{
    public class User_info
    {
        [Key]
        public long id { get; set; }
        
        
        [Display(Name = "تاریخ تولد")]
        public DateTime? birthday { get; set; }

        [Display(Name = "تاریخ استخدام")]
        public DateTime? employment_date { get; set; }

        [Display(Name = "مدرک تحصیلی")]
        public string? degree { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations

        public long user_id { get; set; }
        [ForeignKey("user_id")]
        public User User;
        
        

    }
}
