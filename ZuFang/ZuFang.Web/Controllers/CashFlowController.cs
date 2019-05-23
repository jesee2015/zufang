using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Web.Controllers
{
    [Route("api/cashflow")]
    public class CashFlowController : Controller
    {
        public ICashFlowRepository CashFlowRepository { get; }
        public IUnitOfWork UnitOfWork { get; }
        public CashFlowController(ICashFlowRepository cashFlowRepository, IUnitOfWork unitOfWork)
        {
            CashFlowRepository = cashFlowRepository;
            UnitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CashFlow cashFlow)
        {
            cashFlow.CreationDate = DateTime.Now;
            await CashFlowRepository.AddAsync(cashFlow);
            await UnitOfWork.SaveAsync();
            return Ok(new { code = 200 });
        }

        [HttpGet]
        [Route("byMonth")]
        public async Task<IActionResult> GetByMonth(int month)
        {
            var cashFlows = await CashFlowRepository.GetByMonthAsync(month);
            return Ok(cashFlows);
        }
        [HttpGet]
        [Route("ByHouseId")]
        public async Task<IActionResult> GetByHouseId(int houseId)
        {
            var cashFlows = await CashFlowRepository.GetByHouseId(houseId);
            return Ok(cashFlows);
        }
    }
}
