using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Web.ViewModel
{
    public class VmCashFlow:CashFlow
    {
        public decimal Totle { get; set; }
        public string DisplayCreationDate { get; set; }
    }
}
