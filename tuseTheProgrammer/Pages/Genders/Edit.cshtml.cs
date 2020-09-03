using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tuseTheProgrammer.Models;
using tuseTheProgrammer.Services;

namespace tuseTheProgrammer.Pages.Genders
{
    public class EditModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public Gender Gender { get; set; }
        public EditModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public IActionResult OnGet(int id)
        {
            Gender = _sQLDbContextDataAccess.Genders.Find(id);
            if (Gender == null)
            {
                return RedirectToPage("/ErrorHandler/PageNotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            var result = _sQLDbContextDataAccess.Genders.Attach(Gender);
            result.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sQLDbContextDataAccess.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
