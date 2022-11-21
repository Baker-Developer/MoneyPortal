using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoneyPortal.Models;

namespace MoneyPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<MoneyPortalUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}