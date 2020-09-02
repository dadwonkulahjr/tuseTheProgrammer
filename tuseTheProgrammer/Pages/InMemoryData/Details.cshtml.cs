using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tuseTheProgrammer.Models;
using tuseTheProgrammer.Services;

namespace tuseTheProgrammer.Pages.InMemoryData
{
    public class DetailsModel : PageModel
    {
        private readonly IRepository _repository;
        [BindProperty]
        public Employee Employee { get; set; }
        public DetailsModel(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            Employee = _repository.GetEmployeeById(id);
            if(Employee == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return Page();
        }
    }
}
