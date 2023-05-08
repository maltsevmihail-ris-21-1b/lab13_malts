using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13_malts
{
    internal class Journal
    {
        public List<JournalEntry> journalEntries = new List<JournalEntry>();

        public void AddEntry(CollectionHandlerEventArgs args)
        {
            journalEntries.Add(new JournalEntry(args.Name, args.EventType, args.Source.ToString()));
        }
        public void ShowJournal()
        {
            foreach (var entry in journalEntries)
            {
                Console.WriteLine(entry.ToString() + '\n');
            }
        }
    }
}
