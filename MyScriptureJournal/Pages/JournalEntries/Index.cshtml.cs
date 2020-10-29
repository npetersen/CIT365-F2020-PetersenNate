using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JournalEntryBook { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from m in _context.JournalEntry orderby m.Book select m.Book;

            var journalEntries = from m in _context.JournalEntry select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                journalEntries = journalEntries.Where(s => s.Notes.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(JournalEntryBook))
            {
                journalEntries = journalEntries.Where(x => x.Book == JournalEntryBook);
            }

            switch (sortOrder)
            {
                case "book_desc":
                    journalEntries = journalEntries.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    journalEntries = journalEntries.OrderBy(s => s.EntryDate);
                    break;
                case "date_desc":
                    journalEntries = journalEntries.OrderByDescending(s => s.EntryDate);
                    break;
                default:
                    journalEntries = journalEntries.OrderBy(s => s.EntryDate);
                    break;
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await journalEntries.ToListAsync();
        }
    }
}
