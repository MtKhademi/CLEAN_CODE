using _02_StatePattern._02Try.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._02Try
{
    internal class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }


        public IStatePost State { get; set; }
        public UserRole User { get; set; } = UserRole.Writter;

        public Post()
        {
            State = new DraftState(this);
        }

        public void Pulish()
        {
            State.Publish();
        }

    }
}
