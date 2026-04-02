using System;

namespace LightHTMLObserver
{
    public class LightButton : LightElementNode
    {
        public string Text { get; set; }

        public LightButton(string text)
        {
            Text = text;
        }

        public override void Render()
        {
            Console.WriteLine($"<button>{Text}</button>");
        }

        public void Click()
        {
            Console.WriteLine("Button clicked!");
            DispatchEvent(EventType.Click);
        }

        public void Hover()
        {
            Console.WriteLine("Mouse over button!");
            DispatchEvent(EventType.MouseOver);
        }
    }
}