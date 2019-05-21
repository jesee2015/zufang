using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ZuFang.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("cashflow");
        }
    }
}
