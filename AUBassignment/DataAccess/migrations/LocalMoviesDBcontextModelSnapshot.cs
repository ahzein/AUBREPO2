﻿// <auto-generated />
using System;
using DataAccess.DataEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(LocalMoviesDBcontext))]
    partial class LocalMoviesDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModels.Genre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Movieid");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DataModels.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("adult")
                        .HasColumnType("bit");

                    b.Property<string>("backdrop_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("budget")
                        .HasColumnType("int");

                    b.Property<string>("homepage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imdb_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("original_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("popularity")
                        .HasColumnType("real");

                    b.Property<string>("poster_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("release_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("revenue")
                        .HasColumnType("int");

                    b.Property<int>("runtime")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tagline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("video")
                        .HasColumnType("bit");

                    b.Property<float>("vote_average")
                        .HasColumnType("real");

                    b.Property<int>("vote_count")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DataModels.Production_Companies", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<string>("logo_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origin_country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Movieid");

                    b.ToTable("Production_Companies");
                });

            modelBuilder.Entity("DataModels.Production_Countries", b =>
                {
                    b.Property<string>("iso_3166_1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iso_3166_1");

                    b.HasIndex("Movieid");

                    b.ToTable("Production_Countries");
                });

            modelBuilder.Entity("DataModels.Spoken_Languages", b =>
                {
                    b.Property<string>("english_name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<string>("iso_639_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("english_name");

                    b.HasIndex("Movieid");

                    b.ToTable("Spoken_Languages");
                });

            modelBuilder.Entity("DataModels.Genre", b =>
                {
                    b.HasOne("DataModels.Movie", null)
                        .WithMany("genres")
                        .HasForeignKey("Movieid");
                });

            modelBuilder.Entity("DataModels.Production_Companies", b =>
                {
                    b.HasOne("DataModels.Movie", null)
                        .WithMany("production_companies")
                        .HasForeignKey("Movieid");
                });

            modelBuilder.Entity("DataModels.Production_Countries", b =>
                {
                    b.HasOne("DataModels.Movie", null)
                        .WithMany("production_countries")
                        .HasForeignKey("Movieid");
                });

            modelBuilder.Entity("DataModels.Spoken_Languages", b =>
                {
                    b.HasOne("DataModels.Movie", null)
                        .WithMany("spoken_languages")
                        .HasForeignKey("Movieid");
                });
#pragma warning restore 612, 618
        }
    }
}
