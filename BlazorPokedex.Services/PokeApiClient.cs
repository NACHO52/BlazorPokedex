using BlazorPokedex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResultObject> GetAllPokemons(PaginationParameters paginationParameters)
        {
            string json = await _httpClient.GetStringAsync($"pokemon?limit={paginationParameters.PageSize}&offset={paginationParameters.Offset}");
            ResultObject pokemonList = JsonConvert.DeserializeObject<ResultObject>(json);
            return pokemonList;
            //var resultList = new List<Pokemon>();

            //foreach (var pokemon in pokemonList.Pokemons)
            //{
            //    resultList.Add(await GetPokemon(pokemon.Name));
            //}

            //return resultList;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            string json = (await _httpClient.GetStringAsync($"pokemon/{name}"));
            return JsonConvert.DeserializeObject<Pokemon>(json);
        }
    }
}
