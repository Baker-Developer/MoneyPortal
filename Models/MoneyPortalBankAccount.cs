using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
    public class MoneyPortalBankAccount
    {
        // Primary Key
        public int Id { get; set; }
        // Foriegn Key
        public int MoneyAppUserId { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public string? AccountName { get; set; }
        [Required]
        [Display(Name = "Starting Balance")]
        public int? StartingBalance { get; set; }
        [Required]
        [Display(Name = "Low Balance")]
        public int? LowBalanceAlert { get; set; }

        [Display(Name = "Current Balance")]
        public int? CurrentBalance { get; set; }

        [Display(Name = "Monthly Spending")]
        public int? MonthlySpending { get; set; }

        [Display(Name = "Monthly Deposits")]
        public int? MonthlyDeposits { get; set; }

        [Display(Name = "Monthly Transactions")]
        public int? MonthlyTransactions { get; set; }


        //Navigation Properties
    }
}
