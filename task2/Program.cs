using System;

namespace LightHTMLObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new LightButton("Submit");

            button.AddEventListener(EventType.Click, () =>
            {
                Console.WriteLine("Listener 1: Button was clicked.");
            });

            button.AddEventListener(EventType.Click, () =>
            {
                Console.WriteLine("Listener 2: Logging click.");
            });

            button.AddEventListener(EventType.MouseOver, () =>
            {
                Console.WriteLine("Listener: Hover detected.");
            });


            button.Render();

            Console.WriteLine();

            button.Click();

            Console.WriteLine();

            button.Hover();

            Console.WriteLine();

            Console.WriteLine("Removing one click listener...\n");

            Action removable = () =>
            {
                Console.WriteLine("This will be removed.");
            };

            button.AddEventListener(EventType.Click, removable);
            button.RemoveEventListener(EventType.Click, removable);

            button.Click();
        }
    }
}