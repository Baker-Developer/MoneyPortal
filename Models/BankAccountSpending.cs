using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
	public class BankAccountSpending
	{
		public int Id { get; set; }
		[Display(Name = "Monthly Spending")]
		public int MonthlySpending { get; set; }
	}
}
