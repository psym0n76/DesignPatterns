using System.Collections.Generic;

namespace Iterator
{
    public class BrowserHistory
    {
        public List<string> Urls { get; } = new List<string>();

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastUrl = Urls[lastIndex];
            Urls.Remove(lastUrl);

            return lastUrl;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowserHistory _history;
            private int _index;

            public ListIterator(BrowserHistory history)
            {
                _history = history;
            }

            public bool HasNext()
            {
                return (_index < _history.Urls.Count);
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}