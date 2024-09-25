using ClienteApp1.Data;
using ClienteApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteApp1.Pages
{
public class CreateModel : PageModel
{
private readonly AppDbContext _context;
public CreateModel(AppDbContext context)
{
   _context = context;
}
 [BindProperty]
public Cliente Cliente { get; set; }
public IActionResult OnPost()
{
  if (!ModelState.IsValid)
 {
  return Page();
}
 _context.Clientes.Add(Cliente);
  _context.SaveChanges();
 return RedirectToPage("/Index");
   }
  }
}
