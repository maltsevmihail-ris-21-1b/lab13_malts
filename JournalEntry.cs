using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13_malts
{
    internal class JournalEntry
    {
        public string? Name { get; set; }
        public string? ChangeType { get; set; }
        public string? SourceInfo { get; set; }
        public JournalEntry(string? name, string? changeType, string? sourceInfo)
        {
            Name = name;
            ChangeType = changeType;
            SourceInfo = sourceInfo;
        }
        public override string ToString()
        {
            return $"Name: {Name}, ChangeType: {ChangeType}, SourceInfo: {SourceInfo}";
        }
    }
}
