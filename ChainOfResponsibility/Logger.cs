using System;

namespace ChainOfResponsibility
{
    public class Logger : ObjectHandler
    {
        public Logger(ObjectHandler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}