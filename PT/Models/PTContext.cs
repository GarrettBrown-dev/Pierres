using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PT.Models
{
    public class PTContext : IdentityDbContext<ApplicationUser>
    {

    }
}