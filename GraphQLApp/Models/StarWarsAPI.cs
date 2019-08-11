using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace GraphQLApp.Models
{
    public class StarWarsAPI
    {


        public string title { get; set; }
        public string director { get; set; }
        public string id { get; set; }
        public string releaseDate { get; set; }





        public StarWarsAPI()
        {
        }


    }
}
