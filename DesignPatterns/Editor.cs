namespace DesignPatterns
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState => new EditorState(Content);

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

    }
}