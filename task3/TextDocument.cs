using System;

namespace TextEditorMemento
{
    public class TextDocument
    {
        private string content;

        public TextDocument(string initialText = "")
        {
            content = initialText;
        }

        public void Write(string text)
        {
            content += text;
        }

        public void SetText(string text)
        {
            content = text;
        }

        public string GetText()
        {
            return content;
        }

        // CREATE MEMENTOjyukyuky
        public Memento Save()
        {
            return new Memento(content);
        }

        // RESTORE FROM MEMENTOyukyukjkh
        public void Restore(Memento memento)
        {
            content = memento.GetState();
        }

        public class Memento
        {
            private readonly string state;

            internal Memento(string state)
            {
                this.state = state;
            }

            internal string GetState()
            {
                return state;
            }
        }
    }
}