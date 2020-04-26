using System;

namespace ChainOfResponsibility
{
    public class Compressor : ObjectHandler
    {
        public Compressor(ObjectHandler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}