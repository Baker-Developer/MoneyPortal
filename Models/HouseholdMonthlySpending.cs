using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class HouseholdMonthlySpending
    {
        public int Id { get; set; }
        [Display(Name = "Monthly Spending")]
        public int TotalHouseholdMonthlySpending { get; set; }
    }
}
