using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BlazorPokedex.Models
{
    public class ResultObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
