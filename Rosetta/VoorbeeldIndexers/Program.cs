using System;
using System.Collections.Generic;

namespace VoorbeeldIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var indexerVoorbeeld = new IndexerVoorbeeld();

            //Console.WriteLine(indexerVoorbeeld[0]);
            //Console.WriteLine(indexerVoorbeeld[1]);
            //Console.WriteLine(indexerVoorbeeld[2]);
            //Console.WriteLine(indexerVoorbeeld[3]);

            var indexerVoorbeeld2 = new IndexerVoorbeeldMetSetter();

            indexerVoorbeeld2["alpha"] = "beta";
            Console.WriteLine(indexerVoorbeeld2["alpha"]);

        }
    }


    class IndexerVoorbeeld
    {
        public string this[int index]
        {
            get 
            {
                switch (index)
                {
                    case 1:
                        return "een";
                    case 2:
                        return "twee";
                    default:
                        return "een ander getal";
                }
            }
        }
    }

    class IndexerVoorbeeldMetSetter
    {
        readonly Dictionary<string, string> items;

        public IndexerVoorbeeldMetSetter()
        {
            items = new Dictionary<string, string>();
        }

        public string this[string index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }

}
