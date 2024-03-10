using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataModels
{
   

    public class MoviesResponse
    {
        public int Page { get; set; }
        public List<Movie> Results { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }

    public class Movie
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }

        [NotMapped]
        public object belongs_to_collection { get; set; }
        public int budget { get; set; }

      //  [NotMapped]
        public Genre[] genres { get; set; }
        public string homepage { get; set; }

        [Key]
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }

       // [NotMapped]
        public Production_Companies[] production_companies { get; set; }

       // [NotMapped]
        public Production_Countries[] production_countries { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }

      //  [NotMapped]
        public Spoken_Languages[] spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
    }

   

    public class Genre
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Production_Companies
    {
        [Key]
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }
    }

    public class Production_Countries
    {
       
        [Key]
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
    }

    public class Spoken_Languages
    {
       
        [Key]
        public string english_name { get; set; }
        public string iso_639_1 { get; set; }
        public string name { get; set; }
    }




}
