using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class HouseholdTotalBudget
    {
        public int Id { get; set; }

        [Display(Name = "Total Budget")]
        public int TotalHouseholdBudget { get; set; }
    }
}
