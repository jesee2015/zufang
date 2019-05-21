using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Core.interfaces;

namespace ZuFang.Web.Controllers
{
    [Route("api/contract")]
    public class ContractController : Controller
    {
        public IContractRepository ContractRepository { get; }
        public IUnitOfWork UnitOfWork { get; }
        public ContractController(IContractRepository contractRepository, IUnitOfWork unitOfWork)
        {
            ContractRepository = contractRepository;
            UnitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Contract> contracts = await ContractRepository.GetAllAsync();
            return Ok(contracts);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Contract contract)
        {
            await ContractRepository.AddAsync(contract);
            await UnitOfWork.SaveAsync();
            return Ok();
        }
    }
}
