using OOP__lab10;
namespace lab13_malts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNewCollection collection1 = new MyNewCollection("Collection 1");
            MyNewCollection collection2 = new MyNewCollection("Collection 2");
            
            Journal journal1 = new Journal();
            Journal journal2 = new Journal();

            collection1.CollectionCountChanged += journal1.AddEntry;
            collection1.CollectionReferenceChanged += journal1.AddEntry;

            collection1.CollectionReferenceChanged += journal2.AddEntry;
            collection2.CollectionReferenceChanged += journal2.AddEntry;

            collection1.Fill(3);

            Engine engine = new Engine().RandomInit();
            collection1.Add(engine);
            collection1.Remove(engine);

            collection1[0] = new Engine().RandomInit();

            collection2.Add(new Engine().RandomInit());
            collection2[0] = new Engine().RandomInit();

            journal1.ShowJournal();
            journal2.ShowJournal();
        }
    }
}