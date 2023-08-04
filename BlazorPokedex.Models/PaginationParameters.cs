using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BlazorPokedex.Models
{
    public class PaginationParameters
    {

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 24;
        public int Offset => (PageNumber - 1) * PageSize;
    }
}
