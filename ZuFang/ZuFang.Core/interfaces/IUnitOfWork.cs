using ZuFang.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZuFang.Core.interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
