using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Core.interfaces;

namespace ZuFang.Web.Controllers
{
    [Route("api/house")]
    public class HouseController : Controller
    {
        public IHouseRepository HouseRepository { get; }
        public IUnitOfWork UnitOfWork { get; }

        public HouseController(IHouseRepository houseRepository, IUnitOfWork unitOfWork)
        {
            HouseRepository = houseRepository;
            UnitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<House> houses = await HouseRepository.GetAllAsync();
            return Ok(houses);
        }

        [HttpPost]
        public async Task<IActionResult> Post(House house)
        {
            await HouseRepository.AddAsync(house);
            await UnitOfWork.SaveAsync();
            return Ok(new { code = 200 });
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await HouseRepository.DeleteById(id);
            await UnitOfWork.SaveAsync();
            return Ok(new { code = 200 });
        }

    }
}
