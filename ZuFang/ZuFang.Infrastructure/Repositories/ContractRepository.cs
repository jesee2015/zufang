using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
