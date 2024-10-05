using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace parcial_antaurco.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<parcial_antaurco.Models.Remesa> Remesas { get; set; }
    public DbSet<parcial_antaurco.Models.Conversion> Conversiones { get; set; }
}
