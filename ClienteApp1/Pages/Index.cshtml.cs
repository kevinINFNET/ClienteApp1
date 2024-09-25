using ClienteApp1.Data;
using ClienteApp1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace ClienteApp1.Pages
{
public class IndexModel : PageModel
{
 private readonly AppDbContext _context;
 public IndexModel(AppDbContext context)
{
  _context = context;
}
public IList<Cliente> Clientes { get; set; }
public async Task OnGetAsync()
        {
 Clientes = await _context.Clientes.ToListAsync();
        }
    }
}
