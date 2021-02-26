using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Product.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Product.Db
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Producten> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=product.db");
    }
}
