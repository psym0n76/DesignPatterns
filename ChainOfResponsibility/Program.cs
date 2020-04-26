using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //auth
            //logger
            //compressoir


            //chain of items
            var compressor = new Compressor(null );
            var logger = new Logger(compressor);
            var auth = new Authenticator(logger);

            var server = new WebServer(auth);

            server.Handle(new HttpRequest("admin", "1234"));

            Console.ReadKey();
        }
    }
}
