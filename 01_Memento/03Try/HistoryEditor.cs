using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._03Try
{
    internal class HistoryEditor
    {

        private readonly Editor editor;

        public HistoryEditor(Editor editor)
        {
            this.editor = editor;
        }

        private List<EditorState> _states = new List<EditorState>();
        public void Backup() => _states.Add(editor.CreateState());
        internal EditorState Undo()
        {
            var lastState = _states.Last();
            _states.Remove(lastState);
            return lastState;
        }
    }
}
