using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "hobbit 3",
                    ReleaseDate = DateTime.Parse("2016-2-12"),
                    Genre = "WAR",
                    Rating = "S",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "after life 2 ",
                    ReleaseDate = DateTime.Parse("2024-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "life of pi",
                    ReleaseDate = DateTime.Parse("2015-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio 2",
                    ReleaseDate = DateTime.Parse("2013-4-15"),
                    Genre = "Western",
                    Rating = "A",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Munna boy  Mbbs",
                    ReleaseDate = DateTime.Parse("2004-1-29"),
                    Genre = "Comedy",
                    Rating = "S",
                    Price = 4.79M
                }
            );
            context.SaveChanges();
        }
    }
}