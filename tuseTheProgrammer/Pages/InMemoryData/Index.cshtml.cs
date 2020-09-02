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
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public IEnumerable<Employee> Employees { get; set; }
        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            Employees = _repository.GetEmployees();
        }
    }
}
