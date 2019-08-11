using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Xamarin.Forms;
using GraphQLApp.Models;

namespace GraphQLApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            var client = new GraphQLClient("https://swapi.apis.guru/");

            GraphQLRequest graphQLRequest = new GraphQLRequest
            {
                Query = "query{ allFilms { films {title, director,id, releaseDate } } }"
            };
            GraphQLResponse graphQLResponse = await client.PostAsync(graphQLRequest);
            ListStarWars.ItemsSource = graphQLResponse.Data.allFilms.films.ToObject<List<StarWarsAPI>>();

        }

    }
}
