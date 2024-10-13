using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._01Try
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
            _states.Add((_title, _content));
            _title = title;
        }

        public void SetContent(string content)
        {
            _states.Add((_title, _content));
            _content = content;
        }


        private List<(string title, string content)> _states = new List<(string title, string content)>();


        public void Undo()
        {
            var lastState = _states.Last();
            _states.Remove(lastState);

            _title = lastState.title;
            _content = lastState.content;
        }

        public override string ToString() => $"STATE : {Title} : {Content}";
    }
}
