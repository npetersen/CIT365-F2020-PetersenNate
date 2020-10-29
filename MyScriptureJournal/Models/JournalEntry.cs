using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EntryDate { get; set; }

        [Required]
        public String Book { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }

        [Required]
        public String Notes { get; set; }
    }
}
