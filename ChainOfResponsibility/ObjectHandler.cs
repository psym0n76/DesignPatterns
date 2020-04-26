namespace ChainOfResponsibility
{
    public abstract class ObjectHandler
    {
        private readonly ObjectHandler _next;

        protected ObjectHandler(ObjectHandler next)
        {
            this._next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            _next?.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}