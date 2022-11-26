namespace MoneyPortal.Models
{
    public class MoneyPortalBankAccount
    {
        public int id { get; set; }
        public int transactions { get; set; }
        public int spending { get; set; }
        public int balance { get; set; }

        public int deposits { get; set; }

        //Navigation Properties
    }
}
