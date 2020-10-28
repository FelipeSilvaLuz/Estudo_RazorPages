using System.Collections.Generic;
using Estudo_RazorPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Estudo_RazorPages.Pages.Admin.Credito
{
    public class IndexModel : PageModel
    {
        public readonly DataBase _dataBase;

        public IndexModel(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IEnumerable<Credit> Credits { get; private set; }

        public void OnGet()
        {
            Credits = _dataBase.Credit;
        }
    }
}