using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HaberSiteFinal.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=HaberDb; integrated security=false");
        }
        public DbSet<Haber> habers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
