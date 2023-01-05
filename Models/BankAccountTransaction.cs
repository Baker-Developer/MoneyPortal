using MoneyPortal.Models.Enums;

namespace MoneyPortal.Models
{
    public class BankAccountTransaction
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public string? TransactionDescription { get; set; }
    }
}
