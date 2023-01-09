using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
    public class Household
    {
        public int Id { get; set; }

        [Display(Name = "Household")]
        public int? HouseholdId { get; set; }

        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Household Name")]
        public string? HouseholdName { get; set; }

        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Household Greeting")]
        public string? HouseholdGreeting { get; set; }



        // Navigation Properties


    }
}
