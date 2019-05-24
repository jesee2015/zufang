using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using AutoMapper;
using ZuFang.Web.ViewModel;

namespace ZuFang.Web.Controllers
{
    [Route("api/cashflow")]
    public class CashFlowController : Controller
    {
        public ICashFlowRepository CashFlowRepository { get; }
        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }

        public CashFlowController(ICashFlowRepository cashFlowRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            CashFlowRepository = cashFlowRepository;
            UnitOfWork = unitOfWork;
            Mapper = mapper;
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
            var VmcashFlows = Mapper.Map<IEnumerable<VmCashFlow>>(cashFlows);
            return Ok(VmcashFlows);
        }
        [HttpGet]
        [Route("ByHouseId")]
        public async Task<IActionResult> GetByHouseId(int houseId)
        {
            var cashFlows = await CashFlowRepository.GetByHouseId(houseId);
            //var VmcashFlows = Mapper.Map<IEnumerable<VmCashFlow>>(cashFlows);
            return Ok(cashFlows);
        }
    }
}
