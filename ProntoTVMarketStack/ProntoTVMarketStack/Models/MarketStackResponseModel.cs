using System.Text.Json.Serialization;

namespace ProntoTVMarketStack.Models
{
    public class MarketStackResponseModel
    {
        [JsonPropertyName("open")]
        public double Open { get; set; }

        [JsonPropertyName("high")]
        public double High { get; set; }

        [JsonPropertyName("low")]
        public double Low { get; set; }

        [JsonPropertyName("close")]
        public double Close { get; set; }

        [JsonPropertyName("volume")]
        public double Volume { get; set; }

        [JsonPropertyName("adj_high")]
        public double AdjHigh { get; set; }

        [JsonPropertyName("adj_low")]
        public double AdjLow { get; set; }

        [JsonPropertyName("adj_close")]
        public double AdjClose { get; set; }

        [JsonPropertyName("adj_open")]
        public double AdjOpen { get; set; }

        [JsonPropertyName("adj_volume")]
        public double AdjVolume { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }
    }
}
