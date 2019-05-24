using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Web.ViewModel;

namespace ZuFang.Web.extension
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Contract, VmContract>()
                .ForMember(des => des.DisplayContractDate, opt => opt.MapFrom<DisplayResolver>())
                .ForMember(des => des.TenDay, opt => { opt.MapFrom(c => c.ContractDate.Day / 10); })
                .ForMember(des => des.HasPay, opt => opt.MapFrom<HasPayResolver>());

        }
    }

    public class DisplayResolver : IValueResolver<Contract, VmContract, string>
    {
        public string Resolve(Contract source, VmContract destination, string destMember, ResolutionContext context)
        {
            return source.ContractDate.ToString("yyyy年MM月dd日");
        }
    }
    public class HasPayResolver : IValueResolver<Contract, VmContract, bool>
    {
        public bool Resolve(Contract source, VmContract destination, bool destMember, ResolutionContext context)
        {
            var month = DateTime.Now.Month;
            var res = source.CashFlows.Any(c => c.CreationDate.Month == month);
            return res;
        }
    }
}
