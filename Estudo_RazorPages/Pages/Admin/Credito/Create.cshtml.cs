using Estudo_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Estudo_RazorPages.Pages.Admin.Credito
{
    public class CreateModel : PageModel
    {
        public readonly DataBase _dataBase;

        public CreateModel(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty()]
        public Credit Credit { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dataBase.Credit.Add(Credit);
            _dataBase.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}