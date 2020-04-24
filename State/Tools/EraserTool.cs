using System;

namespace State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Eraser Up  icon");
        }
    }
}