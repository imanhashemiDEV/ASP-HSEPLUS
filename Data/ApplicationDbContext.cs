
using HSEPLUS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HSEPLUS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<User_info> User_infos { get; set; } = default!;
        public DbSet<Organization> Organizations { get; set; } = default!;
        public DbSet<Occupation> Occupations { get; set; } = default!;
        public DbSet<Workplace> Workplaces { get; set; } = default!;


    }
}
