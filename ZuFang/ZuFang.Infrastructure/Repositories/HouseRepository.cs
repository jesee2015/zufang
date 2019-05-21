using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ZuFang.Core.entities;
using System.Threading.Tasks;
using ZuFang.Infrastructure.DataBase;

namespace ZuFang.Infrastructure.Repositories
{
    public class HouseRepository : EFRepository<House>, IHouseRepository
    {
        public HouseRepository(MyDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
