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
    public class DetailsModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; set; }
        public DetailsModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public IActionResult OnGet(int id)
        {
            Employee = _sQLDbContextDataAccess.Employees.Find(id);
            Department = _sQLDbContextDataAccess.Departments.Find(id);
            Gender = _sQLDbContextDataAccess.Genders.Find(id);
            if (Employee== null || Gender == null || Department == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return Page();

        }
    }
}
