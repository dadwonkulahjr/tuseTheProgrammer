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
    public class IndexModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public IEnumerable<Employee> Employee { get; set; }
        public IEnumerable<Department> Department { get; set; }
        public IEnumerable<Gender> Gender { get; set; }

        public IndexModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public void OnGet()
        {
            Employee = _sQLDbContextDataAccess.Employees.ToList();
            Department = _sQLDbContextDataAccess.Departments.ToList();
            Gender = _sQLDbContextDataAccess.Genders.ToList();
        }
    }
}
