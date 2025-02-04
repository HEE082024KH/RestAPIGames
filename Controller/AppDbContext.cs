using Microsoft.EntityFrameworkCore;
using RestAPIGames.Model;

namespace RestAPIGames.Controller;

public class AppDbContext : DbContext
{
  public DbSet<Games> Games { get; set; }
  
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}