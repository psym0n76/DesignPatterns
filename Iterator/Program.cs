using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var history = new BrowserHistory();

            history.Push("a");
            history.Push("b");
            history.Push("c");

            foreach (var historyUrl in history.Urls)
            {
                Console.WriteLine(historyUrl);
            }

            var iterator = history.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }
    }
}
