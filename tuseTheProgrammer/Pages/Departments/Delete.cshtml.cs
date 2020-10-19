using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tuseTheProgrammer.Models;
using tuseTheProgrammer.Services;

namespace tuseTheProgrammer.Pages.Departments
{
    public class DeleteModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public Department Department { get; set; }
        public DeleteModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            this._sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public IActionResult OnGet(int id)
        {
            Department = _sQLDbContextDataAccess.Departments.Find(id);
            if(Department == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            _sQLDbContextDataAccess.Departments.Remove(Department);
            _sQLDbContextDataAccess.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
