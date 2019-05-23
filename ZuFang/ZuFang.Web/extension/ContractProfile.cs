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
                .ForMember(des => des.TenDay, opt => { opt.MapFrom(c => c.ContractDate.Day / 10); });
        }
    }

    public class DisplayResolver : IValueResolver<Contract, VmContract, string>
    {
        public string Resolve(Contract source, VmContract destination, string destMember, ResolutionContext context)
        {
            return source.ContractDate.ToString("yyyy年MM月dd日");
        }
    }
}
