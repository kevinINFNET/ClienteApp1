using ClienteApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteApp1.Data
{
 public class AppDbContext : DbContext
{
 public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
 public DbSet<Cliente> Clientes { get; set; }
   }
}
