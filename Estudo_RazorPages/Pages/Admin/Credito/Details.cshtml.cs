using Estudo_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Estudo_RazorPages.Pages.Admin.Credito
{
    public class DetailsModel : PageModel
    {
        public Credit Credit { get; set; }

        public readonly DataBase _dataBase;

        public DetailsModel(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("./Index");
            }

            Credit = _dataBase.Credit.Find(id.Value);

            if(Credit == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}