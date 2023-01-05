using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
	public class BankAccountDeposits
	{
		public int Id { get; set; }
		[Display(Name = "Monthly Deposits")]
		public int MonthlyDeposits { get; set; }
	}
}
