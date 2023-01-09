using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class HouseholdMonthlyDeposits
    {
        public int Id { get; set; }
        [Display(Name = "MonthlyDeposits")]
        public int TotalMonthlyDeposits { get; set; }
    }
}
