using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentaCarContext : DbContext //veritabanı bağlantısı kendi veritabanımızdaki tabloları birleştiricez
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database =RentaCar;Trusted_Connection = true");
           
        }

        public DbSet<Car> Cars //Car entitysini Cars veritabanı tablosuyla bağladım
        {
            get;set; 
        }

        public DbSet<Brand> Brands
        {
            get;set;
        }

        public DbSet<Color> Colors
        {
            get;set;
        }
    }
}
 