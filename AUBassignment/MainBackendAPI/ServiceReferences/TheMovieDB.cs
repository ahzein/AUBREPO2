using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using Newtonsoft.Json;
using RestSharp;

namespace MainBackendAPI.ServiceReferences
{
    public class TheMovieDB
    {


        public static List<Movie>  GetPopularMovies()
        {

            var client = new RestClient("https://api.themoviedb.org/3/movie/popular?language=en-US&page=2");
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI5MGYxYTk3NDE3NzIxZDY2ZDQwNWY1NTRlMDkyYTRiYSIsInN1YiI6IjU0ZjQ5OGE2OTI1MTQxNzk5ZjAwMjFmMiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.AmH9ahcSsro2udQ5FbFbLBM6d62_nlZH8oyKlCJ8x8w");
            IRestResponse response = client.Get(request);

           
            MoviesResponse RetreivedMoviesResponse = JsonConvert.DeserializeObject<MoviesResponse>(response.Content);

            List<Movie> RetreivedMoviesList = RetreivedMoviesResponse.Results;
            return RetreivedMoviesList;



        }


       
        public static Movie GetMovieDetails(int MovieID)
        {

            var client = new RestClient("https://api.themoviedb.org/3/movie/"+ MovieID.ToString());
           // client.AddDefaultParameter("movie_id", MovieID);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI5MGYxYTk3NDE3NzIxZDY2ZDQwNWY1NTRlMDkyYTRiYSIsInN1YiI6IjU0ZjQ5OGE2OTI1MTQxNzk5ZjAwMjFmMiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.AmH9ahcSsro2udQ5FbFbLBM6d62_nlZH8oyKlCJ8x8w");
            IRestResponse response = client.Get(request);

            Movie RetreivedMovieDetails = JsonConvert.DeserializeObject<Movie>(response.Content);
            return RetreivedMovieDetails;

        }




    }
}
