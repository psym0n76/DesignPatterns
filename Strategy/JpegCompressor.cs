using System;

namespace Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing JPEG");
        }
    }
}