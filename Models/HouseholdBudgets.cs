using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class HouseholdBudgets
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Name")]
        public string? BudgetName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Description")]
        public string? BudgetDescription { get; set; }
        [Required]
        [Display(Name = "Budget Amount")]
        public int? BudgetAmount { get; set; }

        // Navigation Properties
    }
}
