using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
	public class BankAccountBalance
	{
		public int Id { get; set; }
		[Display(Name = "Current Balance")]
		public int CurrentBalance { get; set; }

		//public virtual BankAccount? BankAccount { get; set; }
	}
}
