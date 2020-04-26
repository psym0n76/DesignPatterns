namespace ChainOfResponsibility
{
    public class WebServer
    {
        private readonly ObjectHandler _handler;

        public WebServer(ObjectHandler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
           // if (request!=null)
           // {
                _handler.Handle(request);
           // }

        }
    }
}