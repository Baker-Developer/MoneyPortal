namespace MoneyPortal.Models
{
    public class HouseholdMembers
    {
        public int Id { get; set; }

        public ICollection<MoneyPortalUser>? HouseholdUsers { get; set; }

        // Navigation Properties
    }
}
