using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using MainBackendAPI.ServiceReferences;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MainBackendAPI.Controllers
{
   

      [Authorize]
        [ApiController]
        [Route("[controller]")]
        public class MoviesController : ControllerBase
        {

        
        private readonly LocalDBmoviesService _LocalDBmoviesService;
        public MoviesController(LocalDBmoviesService LocalDBmoviesService)
        {
            _LocalDBmoviesService = LocalDBmoviesService;
        }
        


        [HttpPost("GetCloudPopularMovies")]
        public IActionResult GetCloudPopularMovies()
            {



                List<Movie> _PopularMovies = TheMovieDB.GetPopularMovies();


                return Ok(_PopularMovies);


            }

        
        [HttpPost("GetLocalPopularMovies")]
        public IActionResult GetLocalPopularMovies()
        {
            


            var _LocalPopularMovies = GetAllLocalMovies();


            return Ok(_LocalPopularMovies);


        }
       


        [HttpPost("GetMovieDetails")]
        public async Task<IActionResult> GetMovieDetailsAsync(int MovieID)
        {

            Movie _MovieModelLocal =await _LocalDBmoviesService.GetLocalMovieDetails(MovieID);
            Movie _MovieModel;

            //retrieve from local, if null, retreive from cloud
            if (_MovieModelLocal != null)
                _MovieModel = _MovieModelLocal;

            else
                _MovieModel= TheMovieDB.GetMovieDetails(MovieID);


          


            return Ok(_MovieModel);


        }


        [HttpPost("SaveMovieToLocal")]
        public IActionResult SaveMovieToLocal([FromBody] SaveMovieToLocal_REQ_PARAMS p)
        {
            Movie _MovieModelCloud = TheMovieDB.GetMovieDetails(p.MovieID);
            bool SaveStatus = (_LocalDBmoviesService.SaveMovieToDB(_MovieModelCloud));
             
            
            return Ok(SaveStatus);


            //949429
        }

        [HttpPost("DeleteMovieFromLocal")]
        public IActionResult DeleteMovieFromLocal([FromBody] SaveMovieToLocal_REQ_PARAMS p)
        {
            Movie _MovieModelCloud = TheMovieDB.GetMovieDetails(p.MovieID);
            bool SaveStatus = (_LocalDBmoviesService.DeleteMovieTFromDB(_MovieModelCloud));


            return Ok(SaveStatus);


            //949429
        }




        public async Task<ICollection<Movie>> GetAllLocalMovies()
        {
           
            return await _LocalDBmoviesService.GetLocalMovies();


        }


        /////////

        public class SaveMovieToLocal_REQ_PARAMS
        {
            public int MovieID { get; set; }
        }

    }









    
}