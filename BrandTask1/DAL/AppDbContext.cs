using BrandTask1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandTask1.DAL
{
    public class AppDbContext:DbContext
    {

        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSqlLocalDb;Database=BrandsDb;Trusted_Connection=true");
        }
    }
}
