using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSEPLUS.Models
{
    public class Workplace
    {

        [Key]
        public long id { get; set; }

        [Display(Name = "عنوان محل کار")]
        public string? title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [ForeignKey("organization")]
        public long organization_id { get; set; }
        public Organization organization;

    }
}
