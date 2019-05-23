using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ZuFang.Core.entities;
using ZuFang.Infrastructure.DataBase;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ZuFang.Infrastructure.Repositories
{
    public class CashFlowRepository : EFRepository<CashFlow>, ICashFlowRepository
    {
        public new MyDbContext MyDbContext { get; }
        public CashFlowRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            MyDbContext = myDbContext;
        }


        public async Task<IEnumerable<CashFlow>> GetByHouseId(int houseId)
        {
            return await MyDbContext.CashFlows.Where(c => c.HouseId == houseId).OrderByDescending(c => c.CreationDate).ToListAsync();
        }
    }
}
