using HYBRIDAPP.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HYBRIDAPP.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Register> Registers => Set<Register>();
}
