using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._02Try
{


    //-> SRP 
    //-> OCP

    internal class Editor
    {
        private string _title;
        private string _content;

        public string Title => _title;
        public string Content => _content;

        public void SetTitle(string title)
        {
            _title = title;
        }
        public void SetContent(string content)
        {
            _content = content;
        }


        public EditorState CreateState()
            => new EditorState(Title, Content);

        public void Undo(EditorState state)
        {
            _title = state.Title;
            _content = state.Content;
        }

        public override string ToString() => $"STATE : {Title} : {Content}";
    }
}
