﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZuFang.Core.entities
{
    public class CashFlow : BaseEntity
    {
        /// <summary>
        /// 租金
        /// </summary>
        public decimal Rent { get; set; }
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

        public float Water1 { get; set; }
        public float Water2 { get; set; }
        public decimal WaterCharge { get; set; }
        public float Electricity1 { get; set; }
        public float Electricity2 { get; set; }
        public decimal ElectricityCharge { get; set; }

        /// <summary>
        /// 0：押金 1：租金
        /// </summary>
        public int Type { get; set; }


        /// <summary>
        /// 导航属性
        /// </summary>
        public House House { get; set; }
        public int HouseId { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
