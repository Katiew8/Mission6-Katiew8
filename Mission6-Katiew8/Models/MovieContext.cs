using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Katiew8.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext>options): base (options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<CategoryTable> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoryTable>().HasData(
                new CategoryTable { CategoryId = 1, Category="Action"},
                new CategoryTable { CategoryId = 2, Category = "Adventure" },
                new CategoryTable { CategoryId = 3, Category = "Comedy" },
                new CategoryTable { CategoryId = 4, Category = "Drama" },
                new CategoryTable { CategoryId = 5, Category = "Fantasy" },
                new CategoryTable { CategoryId = 6, Category = "Horror" },
                new CategoryTable { CategoryId = 7, Category = "Musical" },
                new CategoryTable { CategoryId = 8, Category = "Mystery" },
                new CategoryTable { CategoryId = 9, Category = "Romance" },
                new CategoryTable { CategoryId = 10, Category = "Rom-Com" },
                new CategoryTable { CategoryId = 11, Category = "Science Fiction" },
                new CategoryTable { CategoryId = 12, Category = "Sports" },
                new CategoryTable { CategoryId = 13, Category = "Thriller" },
                new CategoryTable { CategoryId = 14, Category = "Western" }

            );


            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Gladiator",
                    Year = 2000,
                    Director = "Ridley Scott",
                    Rating ="R",
                    Edited = false,
                    LentTo ="",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 2,
                    CategoryId = 3,
                    Title = "Best in Show",
                    Year = 2000,
                    Director = "Christopher Guest",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "Better Off Dead",
                    Year = 1985,
                    Director = "Savage Steve Holland",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            ); 
        }
    }
}
