using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_nsweiler.Models
{
    public class MovieContext : DbContext // inheritance to make it a context file
    {
        // constructor (no return)
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) // inherits from the base DbContextOptions options
        {

        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb) // overrides the default conditions for OnModelCreating
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    movieId = 1,
                    category = "Action",
                    title = "Avengers",
                    year = "2012",
                    director = "",
                    rating = "PG-13",
                    lentTo = "Styles Weiler",
                    notes = "",
                    edited = false
                },

                new MovieResponse
                {
                    movieId = 2,
                    category = "Action",
                    title = "Star Wars",
                    year = "1977",
                    director = "George Lucas",
                    rating = "PG-13",
                    lentTo = "Styles Weiler",
                    notes = "",
                    edited = false
                },

                new MovieResponse
                {
                    movieId = 3,
                    category = "Action",
                    title = "Rocky",
                    year = "1977",
                    director = "Rocky",
                    rating = "PG",
                    lentTo = "Styles Weiler",
                    notes = "",
                    edited = false
                }

            );
        } 

        // public available to any class in the program
        // private only available within that particular class
        // protected not available to outside classes, but anything within the chain of inheritance can access it
    }
}
