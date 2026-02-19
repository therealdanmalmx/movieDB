using Microsoft.EntityFrameworkCore;
using movieDB.Models;

public class MoviedDbContext(DbContextOptions<MoviedDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movie => Set<Movie>();
}
