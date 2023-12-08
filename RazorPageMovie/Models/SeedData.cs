using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext1(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext1>>()
                ))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentException("NULL RazorPageMovieContext1");
                }

                if (context.Movie.Any())
                {                    
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Nightmare Before Christmas",
                        RealeseDate = DateTime.Parse("1993-10-29"),
                        Genre = "Animation, Musical",
                        Price = 18,
                        Rating = "PG",                        
                    },
                    new Movie
                    {
                        Title = "Coraline",
                        RealeseDate = DateTime.Parse("2009-02-6"),
                        Genre = "Animation, Terror",
                        Price = 60,
                        Rating = "PG",                        
                    },
                    new Movie
                    {
                        Title = "Charly and the Chocolate Factory",
                        RealeseDate = DateTime.Parse("2005-7-29"),
                        Genre = "Musical, Fantasy",
                        Price = 150,
                        Rating = "PG",                        
                    },
                    new Movie
                    {
                        Title = "James and the Giant Peach",
                        RealeseDate = DateTime.Parse("1996-4-12"),
                        Genre = "Animation, Fantasy",
                        Price = 38,
                        Rating = "PG",                        
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
