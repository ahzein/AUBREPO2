using DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataEntities
{
    public class LocalMoviesDBcontext : DbContext
    {

        

        public LocalMoviesDBcontext(DbContextOptions<LocalMoviesDBcontext> options)
            : base(options)
        {
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog=AUB_MOVIESDB;Integrated Security=True");
            
        }
        */


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public DbSet<Production_Companies> Production_Companies { get; set; }
        public DbSet<Production_Countries> Production_Countries { get; set; }
        public DbSet<Spoken_Languages> Spoken_Languages { get; set; }
        
    }

    
}
