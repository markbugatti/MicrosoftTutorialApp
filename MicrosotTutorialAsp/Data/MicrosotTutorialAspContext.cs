using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MicrosotTutorialAsp.Models;

namespace MicrosotTutorialAsp.Data
{
    public class MicrosotTutorialAspContext : DbContext
    {
        public MicrosotTutorialAspContext (DbContextOptions<MicrosotTutorialAspContext> options)
            : base(options)
        {
        }

        public DbSet<MicrosotTutorialAsp.Models.Movie> Movie { get; set; }
    }
}
