using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        //bu metod projenin hangi veritabanı ile ilişkii olduğunu belirteceğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
                                        
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
