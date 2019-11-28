using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicrosotTutorialAsp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MicrosotTutorialAsp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MicrosotTutorialAspContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MicrosotTutorialAspContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Сметана",
                        ProduceDate = DateTime.Parse("2019-11-25"),
                        ProduceTime = DateTime.Parse("11/25/2019 4:56:00 AM"),
                        Type = "Молочные продукты",
                        Price = 29.40M
                    },
                    new Product
                    {
                        Name = "Творог",
                        ProduceDate = DateTime.Parse("2019-11-26"),
                        ProduceTime = DateTime.Parse("11/26/2019 3:36:00 AM"),
                        Type = "Молочные продукты",
                        Price = 29.40M
                    },
                    new Product
                    {
                        Name = "Ковбаса лікарська",
                        ProduceDate = DateTime.Parse("2019-11-22"),
                        ProduceTime = DateTime.Parse("11/26/2019 7:42:00 AM"),
                        Type = "Ковбаси та м'ясо",
                        Price = 100.0M
                    }
                    );

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "5"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "5"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "5"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "5"
                    }
                    );
                context.SaveChanges();
            }

        } 
    }
}
