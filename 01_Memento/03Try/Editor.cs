using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._03Try
{
    internal class Editor
    {
        private string _title;
        private string _content;
        private HistoryEditor _history;

        public string Title => _title;
        public string Content => _content;

        public Editor()
        {
            _history = new HistoryEditor(this);
        }

        public void SetTitle(string title)
        {
            _history.Backup();
            _title = title;
        }
        public void SetContent(string content)
        {
            _history.Backup();
            _content = content;
        }


        internal EditorState CreateState()
            => new EditorState(Title, Content);

        public void Undo()
        {
            var lastState = _history.Undo();
            _title = lastState.Title;
            _content = lastState.Content;
        }

        public override string ToString() => $"STATE : {Title} : {Content}";
    }
}
