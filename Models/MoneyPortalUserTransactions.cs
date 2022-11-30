using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
    public class MoneyPortalUserTransactions
    {
        // Primary Key
        public int Id { get; set; }
        // Foriegn Key
        public int MoneyAppUserId { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public decimal TransactionAmount { get; set; }

        [Required]
        [Display(Name = "Transaction Type")]
        public decimal TransactionType { get; set; }

        [Required]
        [Display(Name = "Memo")]
        public string? TransactionMemo { get; set; }


        //Navigation Properties
    }
}
