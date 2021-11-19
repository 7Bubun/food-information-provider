using System.Collections.Generic;
using DataAccessDapper.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace WebApplication.Pages.Products
{
    public class IndexModel : PageModel
    {
        [BindProperty] public List<ProductViewModel> Products { get; private set; }
        public void OnGet()
        {
            Products = JsonSerializer.Deserialize<List<ProductViewModel>>(TempData.Peek("Products") as string);
        }
    }
}
