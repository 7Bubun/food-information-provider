using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Error
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        [BindProperty] public string ErrorMessage { get; private set; }
        public IActionResult OnGet()
        {
            Handle();
            return Page();
        }

        public IActionResult OnPost()
        {
            Handle();
            return Page();
        }

        private void Handle()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ErrorMessage = exceptionHandler.Error.Message;
        }
    }
}
