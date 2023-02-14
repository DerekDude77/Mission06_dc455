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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    EntryID = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
