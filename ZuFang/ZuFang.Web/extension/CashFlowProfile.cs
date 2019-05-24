using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;
using ZuFang.Web.ViewModel;

namespace ZuFang.Web.extension
{
    public class CashFlowProfile : Profile
    {
        public CashFlowProfile()
        {
            CreateMap<CashFlow, VmCashFlow>()
                .ForMember(des => des.Totle, opt => opt.MapFrom(c => c.Rent + c.ManageCharge + c.NetCharge + c.CleanCharge + c.WaterCharge + c.ElectricityCharge))
                .ForMember(des => des.DisplayCreationDate, opt => opt.MapFrom(c =>
                     c.CreationDate.ToString("yyyy年MM月dd日 HH:mm:ss")
                ));
        }
    }
}
