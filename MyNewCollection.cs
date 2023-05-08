using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP__lab10;

namespace lab13_malts
{
    internal class MyNewCollection : MyCollection
    {
        public string? Name
        {
            get;
            set;
        }

        public delegate void CollectionHandler(CollectionHandlerEventArgs e);

        public event CollectionHandler? CollectionCountChanged;
        public event CollectionHandler? CollectionReferenceChanged;

        public MyNewCollection(string? name)
        {
            this.Name = name;
        }

        public void OnCollectionCountChanged(CollectionHandlerEventArgs e)
        {
            if (CollectionCountChanged != null)
            {
                CollectionCountChanged(e);
            }
        }

        public void OnCollectionReferenceChanged(CollectionHandlerEventArgs e)
        {
            if (CollectionReferenceChanged != null)
            {
                CollectionReferenceChanged(e);
            }
        }

        public override bool Remove(Engine engine)
        {
            if (base.Remove(engine))
            {
                OnCollectionCountChanged(new CollectionHandlerEventArgs(Name, "remove", engine));
                return true;
            }
            return false;
        }

        public override void Add(Engine t)
        {
            OnCollectionCountChanged(new CollectionHandlerEventArgs(Name, "add", t));
            base.Add(t);
        }
        public override Engine this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                OnCollectionReferenceChanged(new CollectionHandlerEventArgs(Name, "changed", value));
                base[index] = value;
            }
        }
    }
}
