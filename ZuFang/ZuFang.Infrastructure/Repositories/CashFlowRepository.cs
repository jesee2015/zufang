using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZuFang.Infrastructure.Repositories
{
    public class CashFlowRepository : ICashFlowRepository
    {
        public CashFlowRepository()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
