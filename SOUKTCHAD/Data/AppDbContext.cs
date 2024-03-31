using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SOUKTCHAD.Models;

namespace SOUKTCHAD.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<CATIGORY> CATIGORYS { get; set; }
        public DbSet<PRODUCT> PRODUCTS { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PRODUCT>()
            .HasOne(b => b.CATIGORY)
            .WithMany(a => a.PRODUCTS)
            .HasForeignKey(b => b.CATIGORYID);
        }
    }
}
