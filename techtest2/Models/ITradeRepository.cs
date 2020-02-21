using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public interface ITradeRepository
    {
        List<Trade> GetTrades();
        List<Level> GetLevelsByTradeId(int tradeId);
        List<Language> GetLanguages();

        int Save(TradingInfoDto aTrade);
        List<tradingInfo> GetAllList();
    }
}
