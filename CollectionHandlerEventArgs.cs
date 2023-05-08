using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP__lab10;

namespace lab13_malts
{
    internal class CollectionHandlerEventArgs : EventArgs
    {
        public string? Name
        {
            get;
            set;
        }

        public string? EventType
        {
            get;
            set;
        }

        public Engine? Source
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EventType: {EventType}, Source: {Source.ToString}";
        }
        public CollectionHandlerEventArgs(string name, string eventtype, Engine? source)
        {
            Name = name;
            EventType = eventtype;
            Source = source;
        }
    }
}
