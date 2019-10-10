using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MicrosotTutorialAsp.Data;
using MicrosotTutorialAsp.Models;

namespace MicrosotTutorialAsp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MicrosotTutorialAsp.Data.MicrosotTutorialAspContext _context;

        public DetailsModel(MicrosotTutorialAsp.Data.MicrosotTutorialAspContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
