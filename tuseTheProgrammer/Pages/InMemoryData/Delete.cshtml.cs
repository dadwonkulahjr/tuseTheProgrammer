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
    public class DeleteModel : PageModel
    {
        private readonly IRepository _repository;
        [BindProperty]
        public Employee Employee { get; set; }
        public DeleteModel(IRepository repository)
        {
            this._repository = repository;
        }
        public void OnGet(int id)
        {
            Employee = _repository.GetEmployeeById(id);
           
        }
        public IActionResult OnPost()
        {
            Employee = _repository.DeleteExistingEmployee(Employee.Id);
            if(Employee == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return RedirectToPage("Index");
        }
    }
}
