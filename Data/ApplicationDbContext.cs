using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Edoc.Models;

namespace Edoc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Edoc.Models.Specialization>? Specialization { get; set; }
        public DbSet<Edoc.Models.Doctor>? Doctor { get; set; }
        public DbSet<Edoc.Models.Patient>? Patient { get; set; }
    }
}