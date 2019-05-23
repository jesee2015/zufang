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
            modelBuilder.Entity<House>().HasData(new List<House>
            {
                new House
                {
                     Id=1,
                     HouseName="1号公寓",
                     CreationDate=DateTime.Now
                },
                new House
                {
                     Id=2,
                     HouseName="青年公寓",
                     CreationDate=DateTime.Now
                },
                new House
                {
                     Id=3,
                     HouseName="柠檬公寓",
                     CreationDate=DateTime.Now
                }

            });
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new BillItemConfiguration());
        }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<House> Houses { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }
    }
}
