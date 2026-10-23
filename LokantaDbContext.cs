using Microsoft.EntityFrameworkCore;

public class LokantaDbContext : DbContext
{

    public DbSet<Masa> Masalar { get; set; }
    public DbSet<Adisyon> Adisyonlar { get; set; }
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<Garson> Garsonlar { get; set; }
    public DbSet<SiparisKalemi> SiparisKalemleri { get; set; }
    public DbSet<Gider> Giderler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=lokanta.db");
    }
}