using System;
using System.Collections.Generic;

namespace TextEditorMemento
{
    public class TextEditor
    {
        private TextDocument document;
        private Stack<TextDocument.Memento> history = new();

        public TextEditor(TextDocument document)
        {
            this.document = document;
        }

        public void Write(string text)
        {
            Save(); // save BEFORE change
            document.Write(text);
        }

        public void Save()
        {
            history.Push(document.Save());
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                var memento = history.Pop();
                document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Document: {document.GetText()}");
        }
    }
}