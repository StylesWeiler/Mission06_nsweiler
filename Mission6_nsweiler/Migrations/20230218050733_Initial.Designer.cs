﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_nsweiler.Models;

namespace Mission6_nsweiler.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230218050733_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_nsweiler.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            categoryName = "Action"
                        },
                        new
                        {
                            categoryId = 2,
                            categoryName = "Thriller"
                        },
                        new
                        {
                            categoryId = 3,
                            categoryName = "Drama"
                        },
                        new
                        {
                            categoryId = 4,
                            categoryName = "Western"
                        },
                        new
                        {
                            categoryId = 5,
                            categoryName = "Horror"
                        },
                        new
                        {
                            categoryId = 6,
                            categoryName = "Science Fiction"
                        },
                        new
                        {
                            categoryId = 7,
                            categoryName = "Adventure"
                        },
                        new
                        {
                            categoryId = 8,
                            categoryName = "Comedy"
                        },
                        new
                        {
                            categoryId = 9,
                            categoryName = "Animation"
                        });
                });

            modelBuilder.Entity("Mission6_nsweiler.Models.MovieResponse", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("movieId");

                    b.HasIndex("categoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            categoryId = 1,
                            director = "",
                            edited = false,
                            lentTo = "Styles Weiler",
                            notes = "",
                            rating = "PG-13",
                            title = "Avengers",
                            year = "2012"
                        },
                        new
                        {
                            movieId = 2,
                            categoryId = 1,
                            director = "George Lucas",
                            edited = false,
                            lentTo = "Styles Weiler",
                            notes = "",
                            rating = "PG-13",
                            title = "Star Wars",
                            year = "1977"
                        },
                        new
                        {
                            movieId = 3,
                            categoryId = 1,
                            director = "Rocky",
                            edited = false,
                            lentTo = "Styles Weiler",
                            notes = "",
                            rating = "PG",
                            title = "Rocky",
                            year = "1977"
                        });
                });

            modelBuilder.Entity("Mission6_nsweiler.Models.MovieResponse", b =>
                {
                    b.HasOne("Mission6_nsweiler.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}