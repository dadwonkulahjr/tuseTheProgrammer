using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tuseTheProgrammer.Models;
using tuseTheProgrammer.Services;

namespace tuseTheProgrammer.Pages.Genders
{
    public class CreateModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public Gender Gender { get; set; }
        public CreateModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(Gender == null)
            {
                return Redirect("/ErrorHandler/PageNotFound");
            }
            _sQLDbContextDataAccess.Genders.Add(Gender);
            _sQLDbContextDataAccess.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
