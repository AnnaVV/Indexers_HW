using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Program
    {
        public static void PrintArticle(int itemNumber)
        {
           Store someStore = new Store();

           if (someStore[itemNumber] != null)
           {
               Console.WriteLine(someStore[itemNumber]);
           }
           else 
           {
               Console.WriteLine("There's no such item in the store");
           }
        }

        public static void PrintArticle(string itemName)
        {
            Store someStore = new Store();

            if (someStore[itemName] != null)
            {
                Console.WriteLine(someStore[itemName]);
            }
            else
            {
                Console.WriteLine("There's no such item in the store");
            }
        }
        static void Main(string[] args)
        {
            PrintArticle(3);
            Console.WriteLine(("").PadRight(20, '-'));

            PrintArticle("Peach");
            Console.WriteLine(("").PadRight(20, '-'));

            PrintArticle("fish");

            Console.ReadLine();

        }
    }
}
