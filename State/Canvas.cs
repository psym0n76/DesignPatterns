namespace State
{
    public class Canvas
    {
        public Canvas(ITool currentTool)
        {
            CurrentTool = currentTool;
        }

        private  ITool CurrentTool { get; set; }

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }


    }
}