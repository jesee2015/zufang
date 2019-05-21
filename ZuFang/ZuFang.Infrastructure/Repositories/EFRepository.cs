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
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public MyDbContext MyDbContext { get; }

        public EFRepository(MyDbContext myDbContext)
        {
            MyDbContext = myDbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            entity.CreationDate = DateTime.Now;
           await  MyDbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await MyDbContext.Set<TEntity>().OrderByDescending(c => c.CreationDate).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await MyDbContext.Set<TEntity>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetByMonthAsync(int month)
        {
            return await MyDbContext.Set<TEntity>().Where(c => c.CreationDate.Month == month).OrderByDescending(c => c.CreationDate).ToListAsync();
        }

        public async Task DeleteById(int id)
        {
            var entity = await GetByIdAsync(id);
            MyDbContext.Set<TEntity>().Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetByDateAsync(DateTime dateTime)
        {
            var date = dateTime.Date;
            return await MyDbContext.Set<TEntity>().Where(c => c.CreationDate.Date == date).OrderByDescending(c => c.CreationDate).ToListAsync();
        }

        public async Task EditbyId(TEntity entity)
        {
            var oldEntity = await GetByIdAsync(entity.Id);
        }
    }
}
