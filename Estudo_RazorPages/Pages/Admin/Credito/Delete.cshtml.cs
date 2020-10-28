using Estudo_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Estudo_RazorPages.Pages.Admin.Credito
{
    public class DeleteModel : PageModel
    {
        public readonly DataBase _dataBase;

        public DeleteModel(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        [BindProperty()]
        public Credit Credit { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Credit = _dataBase.Credit.Find(id.Value);

            if (Credit == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cr = _dataBase.Credit.Find(id);

            if (cr != null)
            {
                _dataBase.Credit.Remove(cr);
                _dataBase.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}