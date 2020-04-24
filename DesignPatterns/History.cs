using System.Collections.Generic;

namespace DesignPatterns
{
    public class History
    {
        private readonly List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var lastIndex = _states.Count;
            var lastState = _states[lastIndex - 1];
            _states.Remove(lastState);

            return lastState;
        }
    }
}