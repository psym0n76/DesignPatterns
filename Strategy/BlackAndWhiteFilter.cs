using System;

namespace Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("black and white filter");
        }
    }
}