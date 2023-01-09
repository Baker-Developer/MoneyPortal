﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class BankAccountLowBalance
    {
        public int Id { get; set; }
        [Display(Name = "Low Balance Alert")]
        public int LowBalanceAlert { get; set; }
    }
}
