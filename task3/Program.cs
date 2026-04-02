using System;

namespace TextEditorMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new TextDocument();
            var editor = new TextEditor(document);

            editor.Write("Hello");
            editor.Show();

            editor.Write(" World");
            editor.Show();

            editor.Write("!!!");
            editor.Show();

            Console.WriteLine("\nUndo last change:");
            editor.Undo();
            editor.Show();

            Console.WriteLine("\nUndo again:");
            editor.Undo();
            editor.Show();

            Console.WriteLine("\nUndo again:");
            editor.Undo();
            editor.Show();

            Console.WriteLine("\nUndo again (nothing left):");
            editor.Undo();
        }
    }
}