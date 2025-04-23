using Microsoft.EntityFrameworkCore;
using KHanERP.Models;

namespace KHanERP.Data
{
    public class KHanERPDbContext : DbContext
    {
        // Use primary constructor to simplify initialization
        public KHanERPDbContext(DbContextOptions<KHanERPDbContext> options) : base(options) { }

        // Define DbSet properties for your entities here  
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }

        // Correcting the OnModelCreating method to fix the invalid member access expression issue
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.ManagerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Role)
                .WithMany()
                .HasForeignKey(e => e.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
