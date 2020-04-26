namespace Command.Editor
{
    public class HtmlDocument
    {
        public string Content;

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}