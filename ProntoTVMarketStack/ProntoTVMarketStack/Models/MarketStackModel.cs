using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProntoTVMarketStack.Models
{
    public class MarketStackModel
    {
        [JsonPropertyName("pagination")]
        public PaginationModel Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<MarketStackResponseModel> Data { get; set; }
    }
}
