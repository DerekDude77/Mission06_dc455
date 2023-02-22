using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dc455.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            ) ;

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    EntryID = 1,
                    CategoryID = 1,
                    Title = "The Lord of the Rings: The Two Towers",
                    Year = 2004,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    LentTo = null,
                    Notes = "Best battle ever!"

                },
                new ApplicationResponse
                {
                    EntryID = 2,
                    CategoryID = 1,
                    Title = "The Gray Man",
                    Year = 2022,
                    Director = "Joe/Anthony Russo",
                    Rating = "PG-13",
                    LentTo = null,
                    Notes = "Dope movie"

                },
                new ApplicationResponse
                {
                    EntryID = 3,
                    CategoryID = 1,
                    Title = "Casino Royale",
                    Year = 2006,
                    Director = "Martin Campbell",
                    Rating = "PG-13",
                    LentTo = null,
                    Notes = "GOAT"

                }
                );;
        }
    }
}
