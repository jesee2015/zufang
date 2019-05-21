using System;
using System.Collections.Generic;
using System.Text;

namespace ZuFang.Core.entities
{
    public class Contract : BaseEntity
    {
        public virtual House House { get; set; }
        public virtual Guest Guest { get; set; }
        /// <summary>
        /// 房号
        /// </summary>
        public string RoomNo { get; set; }

        /// <summary>
        /// 合同起始时间
        /// </summary>
        public DateTime ContractDate { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        public int Months { get; set; }
        /// <summary>
        /// 租金
        /// </summary>
        public decimal Rent { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        public decimal Deposit { get; set; }
        /// <summary>
        /// 管理费
        /// </summary>
        public decimal ManageCharge { get; set; }

        /// <summary>
        /// 网费
        /// </summary>
        public decimal NetCharge { get; set; }
        /// <summary>
        /// 卫生费、打扫费
        /// </summary>
        public decimal CleanCharge { get; set; }
        /// <summary>
        /// 水费
        /// </summary>
        public decimal WaterCharge { get; set; }
        /// <summary>
        /// 电费
        /// </summary>
        public decimal ElectricityCharge { get; set; }
        /// <summary>
        /// 门禁费
        /// </summary>
        public decimal Card1Charge { get; set; }
        /// <summary>
        /// 门卡费
        /// </summary>
        public decimal Card2Charge { get; set; }
        /// <summary>
        /// 钥匙费
        /// </summary>
        public decimal KeyCharge { get; set; }
    }
}
