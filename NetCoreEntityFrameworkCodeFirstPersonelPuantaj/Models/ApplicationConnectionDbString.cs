using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models
{
    public class ApplicationConnectionDbString : DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<Vardiya> Vardiya { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=Localhost;port=3306;user=root;password=;database=NetCoreEntityFrameworkCodeFirstPersonelPuantaj")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
