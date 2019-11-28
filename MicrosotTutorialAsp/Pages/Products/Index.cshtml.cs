using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MicrosotTutorialAsp.Data;
using MicrosotTutorialAsp.Models;

namespace MicrosotTutorialAsp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MicrosotTutorialAsp.Data.MicrosotTutorialAspContext _context;

        public IndexModel(MicrosotTutorialAsp.Data.MicrosotTutorialAspContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> nameQuery = from m in _context.Product
                                           orderby m.Name
                                           select m.Name;

            var products = from m in _context.Product
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Type.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ProductName))
            {
                products = products.Where(x => x.Name == ProductName);
            }

            Names = new SelectList(await nameQuery.Distinct().ToListAsync());
            Product = await products.ToListAsync();
            //Product = await _context.Product.ToListAsync();
        }

        public IList<Product> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }
    }
}
