using System.ComponentModel.DataAnnotations;

namespace MoneyPortal.Models
{
	public class BankAccountBalance
	{
		public int Id { get; set; }

		public int CurrentBalance { get; set; }

		//public virtual BankAccount? BankAccount { get; set; }
	}
}
