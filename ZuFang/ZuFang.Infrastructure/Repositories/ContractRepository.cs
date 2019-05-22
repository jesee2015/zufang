using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Core.interfaces;
using ZuFang.Infrastructure.DataBase;

namespace ZuFang.Infrastructure.Repositories
{
    public class ContractRepository : EFRepository<Contract>, IContractRepository
    {
        public ContractRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }

        public override async Task<IEnumerable<Contract>> GetAllAsync()
        {
            return await MyDbContext.Set<Contract>().Include(c => c.House).Include(c => c.Guest).OrderByDescending(c => c.CreationDate).ToListAsync();
        }

        public async Task<IEnumerable<Contract>> GetByHouseId(int houseId)
        {
            return await MyDbContext.Set<Contract>().Include(c => c.House).Include(c => c.Guest).Where(c=>c.HouseId==houseId).OrderByDescending(c => c.CreationDate).ToListAsync();
        }
    }
}
