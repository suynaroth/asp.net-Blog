using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;    

namespace Blog.Models
{
    public class AppDBContext(IConfiguration configuration) : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection"); 
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Categories> Categories { get; set; }
    }
}