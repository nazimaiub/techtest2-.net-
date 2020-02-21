using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public class TradingInfoDto
    {
        public int tradeId { get; set; }
        public string levelName { get; set; }
        public string langName { get; set; }
        public string syllabus { get; set; }
        public IFormFile fileToUploadSyllabus { get; set; }
        public IFormFile fileToUploadTestPlan { get; set; }
        public string Officer { get; set; }
        public string manager { get; set; }
        public string active { get; set; }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int id { get; set; }

        //public int tradeId { get; set; }
        //[Required]
        //[MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        //public string levelName { get; set; }
        //[Required]
        //[MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        //public string language { get; set; }
        //[Required]
        //[MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        //public string syllabus { get; set; }
        //public string syllabusFileName { get; set; }
        //public string testPlanFileName { get; set; }
        //[Required]
        //public string developmentOfficer { get; set; }
        //[Required]
        //public string manager { get; set; }
        //[Required]
        //public DateTime active { get; set; }
    }
}
