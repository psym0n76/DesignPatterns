using System;

namespace Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {

        private string prevContent;
        private readonly HtmlDocument _htmlDocument;
        private readonly History _history;

        public BoldCommand(HtmlDocument htmlDocument, History history)
        {
            this._htmlDocument = htmlDocument;
            _history = history;
        }

        public void Execute()
        {
            prevContent = _htmlDocument.Content;

            _htmlDocument.MakeBold();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _htmlDocument.Content = prevContent;
        }
    }
}