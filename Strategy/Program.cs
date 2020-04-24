using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var imageStorage = new ImageStorage(new JpegCompressor(), new BlackAndWhiteFilter());
            var imageStorage = new ImageStorage();
            imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
        }
    }
}
