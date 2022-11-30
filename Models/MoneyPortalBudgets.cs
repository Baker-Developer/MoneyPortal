namespace MoneyPortal.Models
{
    public class MoneyPortalBudgets
    {
        // Primary Key
        public int Id { get; set; }
        // Foriegn Key
        public int MoneyAppUserId { get; set; }
        public string? Description { get; set; }
        public decimal? BudgetAmount { get; set; }
   
    }
}
