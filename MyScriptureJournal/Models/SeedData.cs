using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.JournalEntry.Any())
                {
                    return;
                }

                context.JournalEntry.AddRange(

                    new JournalEntry
                    {
                        Title = "Favorite Scripture",
                        EntryDate = DateTime.Parse("2020-9-1"),
                        Book = "Moroni",
                        Chapter = 10,
                        Verse = 5,
                        Notes = "This is my favorite scripture."
                    },

                    new JournalEntry
                    {
                        Title = "The Lord's Time",
                        EntryDate = DateTime.Parse("2020-8-2"),
                        Book = "Abraham",
                        Chapter = 3,
                        Verse = 4,
                        Notes = "This gives information on how the Lord's time differs from our (earth) time."
                    },

                    new JournalEntry
                    {
                        Title = "Remember This About Service",
                        EntryDate = DateTime.Parse("2020-8-5"),
                        Book = "Mosiah",
                        Chapter = 2,
                        Verse = 17,
                        Notes = "You always need to remember this scripture and how it defines service."
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
