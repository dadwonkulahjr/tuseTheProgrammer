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
    public class CreateModel : PageModel
    {
        private readonly IRepository _repository;

        public CreateModel(IRepository repository)
        {
            _repository = repository;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            Employee = _repository.AddNewEmployee(Employee);
            return RedirectToPage("Index");
        }
    }
}
