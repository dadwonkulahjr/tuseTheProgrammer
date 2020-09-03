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
    public class IndexModel : PageModel
    {
        private readonly SQLDbContextDataAccess _sQLDbContextDataAccess;
        [BindProperty]
        public IEnumerable<Gender> Gender { get; set; }
        public IndexModel(SQLDbContextDataAccess sQLDbContextDataAccess)
        {
            _sQLDbContextDataAccess = sQLDbContextDataAccess;
        }
        public void OnGet()
        {
            Gender = _sQLDbContextDataAccess.Genders.ToList();
        
        }
        //Do Some work later....
        //public IActionResult OnPost()
        //{

        //}
    }
}
