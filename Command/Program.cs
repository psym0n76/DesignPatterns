using System;
using Command.Editor;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // decoupling the customer service from the button
            // otherwise all code has to be retained in the button 

            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);

            button.Click();

            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();


            var history = new History();
            var document = new HtmlDocument {Content = "Hello World"};

            var bold = new BoldCommand(document,history);
            bold.Execute();
            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);

        }
    }
}
