using Microsoft.EntityFrameworkCore;
using ZuFang.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZuFang.Infrastructure.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new BillItemConfiguration());
        }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<House> Houses { get; set; }
    }
}
