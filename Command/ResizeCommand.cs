using System;

namespace Command
{
    public class ResizeCommand : ICommand   
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}