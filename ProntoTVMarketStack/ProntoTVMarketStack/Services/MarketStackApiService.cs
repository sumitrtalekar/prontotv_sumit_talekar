using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ProntoTVMarketStack.Models;

namespace ProntoTVMarketStack.Services
{
    public class MarketStackApiService: IMarketStackApiService
    {
        private readonly HttpClient _client;

        public MarketStackApiService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("MarketStackApi");
        }

        public async Task<List<MarketStackResponseModel>> GetMarketStack(MarketStackRequestModel request)
        {
            var url = $"/v1/eod?access_key=adc58b4cf14e655360df58601076bd5c&symbols={request.Symbol}&sort=DESC&date_from={request.Date}&date_to={request.Date}";
            MarketStackModel result;
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<MarketStackModel>(stringResponse);
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result.Data;
        }
    }
}
