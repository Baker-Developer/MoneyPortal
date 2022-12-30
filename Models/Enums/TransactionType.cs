using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoneyPortal.Models.Enums
{
    public enum TransactionType
    {
        [Display(Name = "Deposit")]
        Deposit,
        [Display(Name = "Cash Withdawal")]
        CashWithdawal,
        [Display(Name = "Point Of Sale")]
        PointOfSale,
        [Display(Name = "Card Number Entered")]
        CardNumberEntered,
        [Display(Name = "Check")]
        Check,
        [Display(Name = "Transfer")]
        Transfer
    }
}
