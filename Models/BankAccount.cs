using MoneyPortal.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Bank Account Name")]
        public string? AccountName { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public BankAccountType BankAccountType { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Created")]
        public DateTimeOffset DateCreated { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Updated")]
        public DateTimeOffset? DateUpdated { get; set; }

        [Display(Name = "Household")]
        public int HouseholdId { get; set; }

        [Display(Name = "Low Balance Alert")]
        public int LowBalanceAlertId { get; set; }

        [Display(Name = "Current Balance")]
        public int CurrentBalanceId { get; set; }

        [Display(Name = "Monthly Spending")]
        public int MonthlySpendingId { get; set; }

        [Display(Name = "Monthly Deposits")]
        public int MonthlyDepositsId { get; set; }

        [Display(Name = "Monthly Transactions")]
        public int MonthlyTransactionsId { get; set; }

        [Display(Name = "Account Owner")]
        public string? MoneyPortalUserId { get; set; }

        // Navigation Properties
        public virtual ICollection<UserBankAccountTransactions>? UserAccountTransactions { get; set; } = new HashSet<UserBankAccountTransactions>();
        public virtual Household? Household { get; set; }
        public virtual MoneyPortalUser? MoneyPortalUser { get; set; }
        public virtual BankAccountBalance? BankAccountBalance { get; set; }
        public virtual BankAccountDeposits? BankAccountDeposits { get; set; }
        public virtual BankAccountLowBalance? BankAccountLowBalance { get; set; }
        public virtual BankAccountMonthlyTransactions? BankAccountMonthlyTransactions { get; set; }
        public virtual BankAccountSpending? BankAccountSpending { get; set; }
    }
}
