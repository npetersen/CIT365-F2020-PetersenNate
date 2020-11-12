using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-7-17"),
                        Genre = "Documentary",
                        Price = 7.99M,
                        image = "meet-the-mormons.jpg",
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        image = "the-singles-ward.jpg",
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Drama",
                        Price = 9.99M,
                        image = "the-other-side-of-heaven.jpg",
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-13"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        image = "the-rm.jpg",
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}