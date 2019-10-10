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
    public class IndexModel : PageModel
    {
        private readonly MicrosotTutorialAsp.Data.MicrosotTutorialAspContext _context;

        public IndexModel(MicrosotTutorialAsp.Data.MicrosotTutorialAspContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
