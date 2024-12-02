using BTH2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình khóa chính nếu cần (tùy chọn)
            modelBuilder.Entity<User>().HasKey(u => u.IdUser);
        }
    }
}
