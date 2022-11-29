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
        public int TransactionAmount { get; set; }

        [Required]
        [Display(Name = "Transaction Type")]
        public int TransactionType { get; set; }

        [Required]
        [Display(Name = "Memo")]
        public string? TransactionMemo { get; set; }


        //Navigation Properties
    }
}
