namespace Command
{
    public class Button
    {
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            // do something
            _command.Execute();
        }




    }
}