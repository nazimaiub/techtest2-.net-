using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public class TradeRepository : ITradeRepository
    {
        public readonly AppDbContext context;
        private readonly IHostingEnvironment hostingEnvironment;
        public TradeRepository(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.context = context;
            
        }

        public List<tradingInfo> GetAllList()
        {
            var result= context.tradingInfoes.ToList();
            return result;
        }

        public List<Language> GetLanguages()
        {
           return context.languages.ToList();
        }

        public List<Level> GetLevelsByTradeId(int tradeId)
        {
            return context.levels.Where(x => x.tradeId == tradeId).ToList();
        }

        public List<Trade> GetTrades()
        {
            return context.trades.ToList();
        }

        public int Save(TradingInfoDto aTrade)
        {
            string uniqueFileName = null;
            string filePath1=null;
            string filePath2=null;
            if (aTrade.fileToUploadSyllabus != null)
            {
               
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + aTrade.fileToUploadSyllabus.FileName;
                filePath1 = Path.Combine(uploadsFolder, uniqueFileName);
                
                aTrade.fileToUploadSyllabus.CopyTo(new FileStream(filePath1, FileMode.Create));
            }

            if (aTrade.fileToUploadTestPlan != null)
            {

                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + aTrade.fileToUploadTestPlan.FileName;
                filePath2 = Path.Combine(uploadsFolder, uniqueFileName);

                aTrade.fileToUploadTestPlan.CopyTo(new FileStream(filePath2, FileMode.Create));
            }
            tradingInfo tf = new tradingInfo();
            //Trade t = new Trade();
            //t = context.trades.Where(x => x.id == aTrade.tradeId).SingleOrDefault();
            tf.tradeName = context.trades.Where(x => x.id == aTrade.tradeId).SingleOrDefault().tradeName;
            tf.levelName = aTrade.levelName;
            tf.language = aTrade.langName;
            tf.syllabus = aTrade.syllabus;
            tf.syllabusFileName= aTrade.fileToUploadSyllabus.FileName;
            tf.testPlanFileName = aTrade.fileToUploadTestPlan.FileName;
            tf.syllabusFilePath = filePath1;
            tf.testPlanFilePath = filePath2;
            tf.developmentOfficer = aTrade.Officer;
            tf.manager = aTrade.manager;
            tf.active = DateTime.Parse(aTrade.active);

            context.tradingInfoes.Add(tf);
            context.SaveChanges();
            var current = context.tradingInfoes.Where(x=>x.tradeName==tf.tradeName);
            if (current == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
