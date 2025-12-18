using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Suciu_Alexandru_Lab2.Areas.Identity.Data
{
    public class LibraryIdentityContext : IdentityDbContext<IdentityUser>
    {
        public LibraryIdentityContext(DbContextOptions<LibraryIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
