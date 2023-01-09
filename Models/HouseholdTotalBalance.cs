using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class HouseholdTotalBalance
    {
        public int Id { get; set; }

        [Display(Name = "Total Balance")]
        public int TotalBalanceHousehold { get; set; }
    }
}
