using System;

namespace Otus_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new OtusDictionary();

            dictionary.Add(335, "For the Emperor");
            dictionary.Add(32, "WAAAAGHH");
            dictionary.Add(48, "Corpse on throne");
            dictionary.Add(48, "");
            Console.WriteLine("----------------");
            Console.WriteLine(dictionary.Get(335));
            Console.WriteLine(dictionary.Get(32));
            Console.WriteLine(dictionary.Get(48));
            Console.WriteLine(dictionary.Get(55));
            Console.WriteLine("----------------");
            Console.WriteLine(dictionary.storage.Length);
            Console.WriteLine("----------------");
            dictionary.Add(3215, "Death Corpse of Krieg");
            Console.WriteLine(dictionary.storage.Length);
            Console.WriteLine("----------------");
            Console.WriteLine(dictionary.Get(335));
            Console.WriteLine(dictionary.Get(32));
            Console.WriteLine(dictionary.Get(48));
            Console.WriteLine(dictionary.Get(3215));
            Console.WriteLine("----------------");
            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary[10]);
            Console.WriteLine("----------------");
            dictionary.Add(-18, "Inquisition");
            Console.WriteLine(dictionary.Get(-18));

        }
    }
}
