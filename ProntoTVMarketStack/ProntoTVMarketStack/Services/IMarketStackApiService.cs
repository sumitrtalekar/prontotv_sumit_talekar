using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProntoTVMarketStack.Models;

namespace ProntoTVMarketStack.Services
{
    public interface IMarketStackApiService
    {
        Task<List<MarketStackResponseModel>> GetMarketStack(MarketStackRequestModel request);
    }
}
