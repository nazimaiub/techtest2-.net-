using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using techtest2.Models;

namespace techtest2.Controllers
{
   // [Route("api/[controller]")]
   // [ApiController]
    public class TradingController : ControllerBase
    {

        //public static IWebHostEnvironment _enviroment;
        public readonly ITradeRepository _iTradeRepository;
        
        public TradingController(ITradeRepository iTradeRepository)
        {
            this._iTradeRepository = iTradeRepository;
        }
        // GET: api/Trading
        [HttpGet]
        [Route("api/GetAllTrades")]
        public List<Trade> GetAllTrades()
        {
            return _iTradeRepository.GetTrades();
        }
        [HttpGet]
        [Route("api/GetAllLevelsBytradeId")]
        public List<Level> GetAllLevelsBytradeId(int tradeId)
        {
            return _iTradeRepository.GetLevelsByTradeId(tradeId);
        }
        [HttpGet]
        [Route("api/GetLanguages")]
        public List<Language> GetLanguages()
        {
            return _iTradeRepository.GetLanguages();
        }


        [HttpPost]
        [Route("api/Save")]
        public int Save(TradingInfoDto model)
        {
           return _iTradeRepository.Save(model);
           

        }

        [HttpGet]
        [Route("api/getAllList")]
        public List<tradingInfo> getAllList()
        {
            return _iTradeRepository.GetAllList();


        }


        // GET: api/Trading/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Trading
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Trading/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
