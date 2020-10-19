using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tuseTheProgrammer.Models;
using tuseTheProgrammer.Services;

namespace tuseTheProgrammer.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public Employee Employee { get; set; }
        public DeleteModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public IActionResult OnGet(int id)
        {
            Employee = _sQLDbContextDataAccess.Employees.Find(id);
            if(Employee == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Employee = _sQLDbContextDataAccess.Employees.Find(Employee.Id);
            if (Employee == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }

            _sQLDbContextDataAccess.Employees.Remove(Employee);
            _sQLDbContextDataAccess.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
