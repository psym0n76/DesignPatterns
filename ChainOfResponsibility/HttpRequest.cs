namespace ChainOfResponsibility
{
    public class HttpRequest
    {

        //private readonly string _userName;
        //private readonly string _password;

        //public HttpRequest(string userName, string password)
        //{
        //    _userName = userName;
        //    _password = password;
        //}

        public HttpRequest(string username, string password)
        {
            UserName = username;
            Password = password;
        }


        public string UserName { get; }

        public string Password { get; }





    }
}