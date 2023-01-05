using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
	public class BankAccountMonthlyTransactions
	{
		public int Id { get; set; }
		[Display(Name = "Monthly Transactions")]
		public int MonthlyTransactions { get; set; }
	}
}
