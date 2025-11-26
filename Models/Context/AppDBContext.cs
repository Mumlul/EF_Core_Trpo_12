using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Models.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Users;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
