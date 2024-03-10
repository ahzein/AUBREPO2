using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PresentationFM2.Models;
using RestSharp;

namespace PresentationFM2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //login to API Service to get access token
            var Loginclient = new RestClient("http://localhost:5000/Login");
            var Loginrequest = new RestRequest("");
            Loginrequest.AddHeader("accept", "application/json");
            IRestResponse Loginresponse2 = Loginclient.Post(Loginrequest);
            LoginResponse LoginresponseOBJ = JsonConvert.DeserializeObject<LoginResponse>(Loginresponse2.Content);
            
            HttpContext.Session.Set("AuthenticationToken", Encoding.UTF8.GetBytes(LoginresponseOBJ.accessToken));

            /// //////

            var client = new RestClient("http://localhost:5000/Movies/GetCloudPopularMovies");
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            byte[] AccessTokenAR;
            HttpContext.Session.TryGetValue("AuthenticationToken", out AccessTokenAR);
            request.AddHeader("Authorization", "Bearer "+ Encoding.UTF8.GetString(AccessTokenAR));
            IRestResponse response2 = client.Post(request);

            List<DataModels.Movie> RetreivedMoviesList = JsonConvert.DeserializeObject<List<DataModels.Movie>>(response2.Content);



            return View(RetreivedMoviesList);
        }

        
        public IActionResult MovieDetails(string MovieID)
        {

            

            var client = new RestClient("http://localhost:5000/Movies/GetMovieDetails?MovieID="+ MovieID.ToString());
           
            var request = new RestRequest("");
           // client.AddDefaultParameter("MovieID", MovieID);
            request.AddHeader("accept", "application/json");
            byte[] AccessTokenAR;
            HttpContext.Session.TryGetValue("AuthenticationToken", out AccessTokenAR);
            request.AddHeader("Authorization", "Bearer " + Encoding.UTF8.GetString(AccessTokenAR));
            IRestResponse response2 = client.Post(request);

            DataModels.Movie RetreivedMoviesDetail = JsonConvert.DeserializeObject<DataModels.Movie>(response2.Content);



            return View("Details", RetreivedMoviesDetail);
        }

        public IActionResult SaveMovieDetails(string MovieID)
        {


            var client = new RestClient("http://localhost:5000/Movies/SaveMovieToLocal");

            var requestBody = new
            {
                MovieID = MovieID
               
            };

            var request = new RestRequest("");

            request.AddJsonBody(requestBody);
           
            request.AddHeader("accept", "application/json");
            byte[] AccessTokenAR;
            HttpContext.Session.TryGetValue("AuthenticationToken", out AccessTokenAR);
            request.AddHeader("Authorization", "Bearer " + Encoding.UTF8.GetString(AccessTokenAR));

            IRestResponse response2 = client.Post(request);

            //DataModels.Movie RetreivedMoviesDetail = JsonConvert.DeserializeObject<DataModels.Movie>(response2.Content);


            
            return MovieDetails(MovieID);

        }

        public IActionResult DeleteMovieDetails(string MovieID)
        {


            var client = new RestClient("http://localhost:5000/Movies/DeleteMovieFromLocal");

            var requestBody = new
            {
                MovieID = MovieID

            };

            var request = new RestRequest("");

            request.AddJsonBody(requestBody);

            request.AddHeader("accept", "application/json");
            byte[] AccessTokenAR;
            HttpContext.Session.TryGetValue("AuthenticationToken", out AccessTokenAR);
            request.AddHeader("Authorization", "Bearer " + Encoding.UTF8.GetString(AccessTokenAR));

            IRestResponse response2 = client.Post(request);

            //DataModels.Movie RetreivedMoviesDetail = JsonConvert.DeserializeObject<DataModels.Movie>(response2.Content);



            return MovieDetails(MovieID);

        }


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private class LoginResponse
        {
            public bool isAuthenticated { get; set; }
            public string accessToken { get; set; }

        }
    }
}
