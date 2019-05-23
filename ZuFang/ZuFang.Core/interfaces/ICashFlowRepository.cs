using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Core.interfaces
{
    public interface ICashFlowRepository : IRepository<CashFlow>
    {
        Task<IEnumerable<CashFlow>> GetByHouseId(int houseId);
    }
}
