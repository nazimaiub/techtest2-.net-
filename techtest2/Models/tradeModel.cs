using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public class tradeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int tradeId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "levelName cant exceed 50 characters")]
        public string levelName { get; set; }

        


        [Required]
        [MaxLength(50, ErrorMessage = "langName cant exceed 50 characters")]
        public string langName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "syllabus cant exceed 50 characters")]
        public string syllabus { get; set; }
       // public fil syllabus { get; set; }
       // public string syllabus { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "officer cant exceed 50 characters")]
        public string officer { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "manager cant exceed 50 characters")]
        public string manager { get; set; }


        [Required]
        
        public DateTime activedate { get; set; }
    }
}
