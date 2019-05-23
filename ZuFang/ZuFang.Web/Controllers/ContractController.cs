using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Core.interfaces;
using ZuFang.Web.ViewModel;

namespace ZuFang.Web.Controllers
{
    [Route("api/contract")]
    public class ContractController : Controller
    {
        public IContractRepository ContractRepository { get; }
        public IHouseRepository HouseRepository { get; }
        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }

        public ContractController(IContractRepository contractRepository, IHouseRepository houseRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            ContractRepository = contractRepository;
            HouseRepository = houseRepository;
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Contract> contracts = await ContractRepository.GetAllAsync();
            var VmContracts = Mapper.Map<IEnumerable<VmContract>>(contracts);
            return Ok(VmContracts);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Contract contract, string telephone, string guestName)
        {
            contract.House = await HouseRepository.GetByIdAsync(contract.HouseId);
            contract.Guest = new Guest { CreationDate = DateTime.Now, MobilePhone = telephone, Name = guestName };
            await ContractRepository.AddAsync(contract);
            await UnitOfWork.SaveAsync();
            return Ok(new { code = 200 });
        }
        [HttpGet]
        [Route("house")]
        public async Task<IActionResult> GetByHouseId(int houseId)
        {
            IEnumerable<Contract> contracts = await ContractRepository.GetByHouseId(houseId);
            var VmContracts = Mapper.Map<IEnumerable<VmContract>>(contracts);
            return Ok(VmContracts);
        }
    }
}
