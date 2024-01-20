using Microsoft.EntityFrameworkCore;
public class MyHotelDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Chambre> Chambres { get; set; }
    public DbSet<Reservation> Réservations { get; set; }
    public DbSet<Hotel> Hotels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Exercice02HotelEFDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Client>()
            .HasKey(c => c.ClientId);

        modelBuilder.Entity<Chambre>()
            .HasKey(ch => ch.ChambreId);
        modelBuilder.Entity<Chambre>()
            .HasIndex(ch => ch.Numero)
            .IsUnique();

        modelBuilder.Entity<Reservation>()
            .HasKey(r => r.ReservationId);

        modelBuilder.Entity<Client>()
            .HasMany(c => c.Reservations)
            .WithOne(r => r.Client);

        modelBuilder.Entity<Reservation>()
            .HasMany(r => r.Chambres)
            .WithMany(c => c.Reservations);

        modelBuilder.Entity<Chambre>()
            .Property(c => c.Tarif)
            .HasColumnType("decimal(18, 2)");
    }
}