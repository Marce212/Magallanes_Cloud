using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcProduct.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcProductContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                     new Product
                     {
                         Description = "When Harry Met Sally",
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Type = "Romantic Comedy",
                         Quality = "R",
                         Price = 7.99M
                     },

                     new Product
                     {
                         Description = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Type = "Comedy",
                         Quality = "R",
                         Price = 8.99M
                     },

                     new Product
                     {
                         Description = "Ghostbusters 2",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Type = "Comedy",
                         Quality = "R",
                         Price = 9.99M
                     },

                   new Product
                   {
                       Description = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Type = "Western",
                       Quality = "R",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}