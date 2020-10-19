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
    public class IndexModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        public IEnumerable<Department> Department { get; set; }
        public IndexModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public void OnGet()
        {
            Department = _sQLDbContextDataAccess.Departments.ToList();
        }
    }
}
