using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var canvas = new Canvas(new SelectionTool());
            canvas.MouseUp();
            canvas.MouseDown();


        }
    }
}
