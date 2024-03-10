using DataAccess.DataEntities;
using DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessServices
{
    public class MoviesRepo
    {

        protected LocalMoviesDBcontext _context;
        protected DbSet<Movie> MovieSet;

        public MoviesRepo(LocalMoviesDBcontext context)
        {
            _context = context;
            MovieSet = _context.Set<Movie>();
        }

        public async Task<ICollection<Movie>> GetAllMovies()
        {

           return await MovieSet.ToListAsync();
        }

        public Task<Movie> GetLocalMovieDetails(int MovieID)
        {

            var ReturnVal = MovieSet.FirstOrDefaultAsync(c => c.id == MovieID) ;

            return ReturnVal;

        }

        public bool SaveMovieToDB(Movie _Movie)
        {
            try
            {
                _Movie.genres = null;
                _Movie.production_companies = null;
                _Movie.production_countries = null;
                _Movie.spoken_languages = null;

       
                _context.Movies.Add(_Movie);
                


                _context.SaveChanges();
                



                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public bool DeleteMovieTFromDB(Movie _Movie)
        {
            try
            {
                _Movie.genres = null;
                _Movie.production_companies = null;
                _Movie.production_countries = null;
                _Movie.spoken_languages = null;

                _context.Remove(_Movie);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
