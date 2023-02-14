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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Action, Adventure, Drama",
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
                    Category = "Comedy/Mockumentary",
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
                    Category = "Romantic Comedy",
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
