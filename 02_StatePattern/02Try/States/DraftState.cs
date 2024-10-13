using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._02Try.States
{
    internal class DraftState : IStatePost
    {
        private readonly Post post;

        public DraftState(Post post)
        {
            this.post = post;
        }

        public void Publish()
        {
            post.State = new ModerationState(post);
            Console.WriteLine($"Change state [{StateOfPost.Draft} => {StateOfPost.Moderation}]");
        }
    }
}
