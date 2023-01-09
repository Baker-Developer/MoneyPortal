namespace MoneyPortal.Models
{
    public class HouseholdUsersTransactions
    {
        public int Id { get; set; }
        // TODO: IS THIS CORRECT??
        public ICollection<UserBankAccountTransactions>? UserBankAccountTransactions { get; set; }
    }
}
