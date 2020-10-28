using Estudo_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Estudo_RazorPages.Pages.Admin.Credito
{
    public class EditModel : PageModel
    {
        public readonly DataBase _dataBase;

        [BindProperty()]
        public Credit Credit { get; set; }

        public EditModel(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Credit = _dataBase.Credit.Find(id);

            if(Credit == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dataBase.Credit.Update(Credit);
            _dataBase.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}