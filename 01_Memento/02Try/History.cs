using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._02Try
{
    internal class History
    {

        private readonly Editor editor;

        public History(Editor editor)
        {
            this.editor = editor;
        }

        private List<EditorState> _states = new List<EditorState>();
        public void Backup() => _states.Add(editor.CreateState());
        public void Undo()
        {
            var lastState = _states.Last();
            _states.Remove(lastState);
            editor.Undo(lastState);
        }
    }
}
