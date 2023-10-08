using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AAAManagement.Models
{
    public class AAADbContext : IdentityDbContext<PersonIdentity>
    {
        public AAADbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
