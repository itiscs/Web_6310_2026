using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

public class MoviesContext(DbContextOptions<MoviesContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; } = default!;

    public DbSet<Student> Students { get; set; }
}
