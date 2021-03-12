using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProntoTVMarketStack.Models;
using ProntoTVMarketStack.Services;

namespace ProntoTVMarketStack.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("ProntoTVPolicy")]
    [ApiController]
    public class MarketStackController : ControllerBase
    {
        private readonly IMarketStackApiService _marketStackApiService;

        public MarketStackController(IMarketStackApiService marketStackApiService)
        {
            _marketStackApiService = marketStackApiService;
        }

        [HttpPost]
        public async Task<List<MarketStackResponseModel>> GetMarketStack(MarketStackRequestModel request)
        {
            List<MarketStackResponseModel> marketStack = new List<MarketStackResponseModel>();

            if (!(string.IsNullOrEmpty(request.Symbol) && string.IsNullOrEmpty(request.Date)))
            {
                marketStack = await _marketStackApiService.GetMarketStack(request);
            }

            return marketStack;
        }
    }
}
