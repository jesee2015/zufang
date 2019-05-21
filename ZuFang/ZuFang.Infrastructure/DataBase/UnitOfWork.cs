using ZuFang.Core.entities;
using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZuFang.Infrastructure.DataBase
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(MyDbContext myDbContext)
        {
            MyDbContext = myDbContext;
        }

        public MyDbContext MyDbContext { get; }

        public async Task<bool> SaveAsync()
        {
            return await MyDbContext.SaveChangesAsync() > 0;
        }
    }
}
