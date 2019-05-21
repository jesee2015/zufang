using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Core.interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetByDateAsync(DateTime dateTime);
        Task<IEnumerable<TEntity>> GetByMonthAsync(int month);
        Task AddAsync(TEntity entity);
        Task DeleteById(int id);
        Task EditbyId(TEntity entity);
    }
}
