using gameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace gameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
 : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre { ID = 1, Name = "Action" },
            new Genre { ID = 2, Name = "Adventure" },
            new Genre { ID = 3, Name = "RPG" },
            new Genre { ID = 4, Name = "Simulation" },
            new Genre { ID = 5, Name = "Strategy" }
        );

    }

}
