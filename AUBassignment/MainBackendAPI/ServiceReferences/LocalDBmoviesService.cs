using DataAccess.DataAccessServices;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainBackendAPI.ServiceReferences
{
    public class LocalDBmoviesService
    {
        private readonly MoviesRepo _MoviesRepo;

        public LocalDBmoviesService(MoviesRepo MVrepo)
        {
            _MoviesRepo = MVrepo;
          }

        public async Task<ICollection<Movie>>  GetLocalMovies()
        {

            return await _MoviesRepo.GetAllMovies();
        }

        public async Task<Movie> GetLocalMovieDetails(int MovieID)
        {
            return await _MoviesRepo.GetLocalMovieDetails(MovieID);

        }

        public bool SaveMovieToDB(Movie _Movie)
        {
            return _MoviesRepo.SaveMovieToDB(_Movie);
        }

        public bool DeleteMovieTFromDB(Movie _Movie)
        {
            return _MoviesRepo.DeleteMovieTFromDB(_Movie);
        }


    }
}
