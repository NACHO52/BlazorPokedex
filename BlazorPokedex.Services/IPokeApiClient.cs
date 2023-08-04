using BlazorPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {
        Task<ResultObject> GetAllPokemons(PaginationParameters paginationParameters);
        Task<Pokemon> GetPokemon(string name);
    }
}
