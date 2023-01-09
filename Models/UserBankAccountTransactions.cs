using MoneyPortal.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models
{
    public class UserBankAccountTransactions
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Created")]
        public DateTimeOffset DateCreated { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Updated")]
        public DateTimeOffset? DateUpdated { get; set; }

        [Required]
        [Display(Name = "Transaction Type")]
        public TransactionType TransactionType { get; set; }

        [Required]
        [Display(Name = "Memo")]
        public string? TransactionDescription { get; set; }

        // Navigation Properties
        public virtual ICollection<BankAccount> BankAccounts { get; set; } = new HashSet<BankAccount>();    

    }
}
