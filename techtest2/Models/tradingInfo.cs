using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public class tradingInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        public string tradeName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        public string levelName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        public string language { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "name cant exceed 50 characters")]
        public string syllabus { get; set; }
        public string syllabusFileName { get; set; }
        [MaxLength(1000, ErrorMessage = "name cant exceed 1000 characters")]
        public string syllabusFilePath { get; set; }
        public string testPlanFileName { get; set; }
        [MaxLength(1000, ErrorMessage = "name cant exceed 1000 characters")]
        public string testPlanFilePath { get; set; }
        [Required]
        public string developmentOfficer { get; set; }
        [Required]
        public string manager { get; set; }
        [Required]
        public DateTime active { get; set; }
    }
}
