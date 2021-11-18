using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Database
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base()
    {

    }
    public DbSet<Hero> heroes { get; set; }
    public DbSet<Group> groups { get; set; }





  }
}