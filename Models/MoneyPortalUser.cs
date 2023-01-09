using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyPortal.Models
{
    public class MoneyPortalUser : IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
        public string? LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? IImageFile { get; set; }

        [Display(Name = "Avatar")]
        public string? ImageFileName { get; set; }

        public byte[]? ImageFileData { get; set; }

        [Display(Name = "File Extention")]
        public string? ImageContentType { get; set; }

        public int? HouseholdId { get; set; }

        // Navigation Properties
        public virtual Household? Household { get; set; }
        public virtual ICollection<BankAccount>? BankAccount { get; set; } = new HashSet<BankAccount>();
    }
}

