using EfCoreExample.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreExample
{
    public class ETrade2DbContext:DbContext
    {
    
        public DbSet<PersonelBilgileri> PersonelBilgileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-934O58E\SQLEXPRESS;Initial Catalog=ETrade2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
