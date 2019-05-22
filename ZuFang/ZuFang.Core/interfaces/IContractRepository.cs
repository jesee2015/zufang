using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Core.interfaces
{
    public interface IContractRepository : IRepository<Contract>
    {
        Task<IEnumerable<Contract>> GetByHouseId(int houseId);
    }
}
