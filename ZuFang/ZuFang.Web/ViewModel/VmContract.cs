using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZuFang.Core.entities;

namespace ZuFang.Web.ViewModel
{
    public class VmContract : Contract
    {
        public string DisplayContractDate { get; set; }

        /// <summary>
        /// 标记是上旬、中旬、下旬
        /// </summary>
        public int TenDay { get; set; }
    }
}
