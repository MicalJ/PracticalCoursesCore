using Microsoft.EntityFrameworkCore;
using PCDatabase.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDatabase
{
    public class PCContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PREDATOR\SQLEXPRESS;Database=PCDatabase;Trusted_Connection=True;");
        }
    }
}
