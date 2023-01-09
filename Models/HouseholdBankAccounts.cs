namespace MoneyPortal.Models
{
    public class HouseholdBankAccounts
    {
        public int Id { get; set; }

        // TODO: IS THIS CORRECT??
        public ICollection<BankAccount>? BankAccounts { get; set; }
    }
}
