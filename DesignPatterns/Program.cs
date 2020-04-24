using System;

namespace DesignPatterns {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState);

            editor.Content = "b";
            history.Push(editor.CreateState);

            editor.Content = "c";
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);

        }
    }
}
