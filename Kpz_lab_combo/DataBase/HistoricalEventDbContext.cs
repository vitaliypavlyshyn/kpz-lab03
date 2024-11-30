using Kpz_lab_combo.Models;
using Microsoft.EntityFrameworkCore;

namespace Kpz_lab_combo.DataBase;

public class HistoricalEventDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;" +
            " Database=HistoricalEventDbContext;" +
            " Username=postgres;" +
            " Password=123;"
            );
         
    }
    
    public DbSet<HistoricalEventEntity> HistoricalEvents { get; set; }
    public DbSet<ReasonEntity> Reasons { get; set; }
    public DbSet<ConsequenceEntity> Consequences { get; set; }
}