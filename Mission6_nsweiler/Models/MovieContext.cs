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

        public DbSet<MovieResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb) // overrides the default conditions for OnModelCreating
        {

           mb.Entity<Category>().HasData(

               new Category { categoryId = 1, categoryName = "Action" },
               new Category { categoryId = 2, categoryName = "Thriller" },
               new Category { categoryId = 3, categoryName = "Drama" },
               new Category { categoryId = 4, categoryName = "Western" },
               new Category { categoryId = 5, categoryName = "Horror" },
               new Category { categoryId = 6, categoryName = "Science Fiction" },
               new Category { categoryId = 7, categoryName = "Adventure" },
               new Category { categoryId = 8, categoryName = "Comedy" },
               new Category { categoryId = 9, categoryName = "Animation" }

          );

           mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                { 
                    movieId = 1,
                    categoryId = 1,
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
                    categoryId = 1,
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
                    categoryId = 1,
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
