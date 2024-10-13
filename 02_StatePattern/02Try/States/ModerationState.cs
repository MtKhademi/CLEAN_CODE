using _02_StatePattern._01Try;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._02Try.States
{
    internal class ModerationState : IStatePost
    {
        private readonly Post post;

        public ModerationState(Post post)
        {
            this.post = post;
        }

        public void Publish()
        {
            if (post.User == UserRole.Admin)
            {
                post.State = new PublishedState(post);
                Console.WriteLine($"Change state [{StateOfPost.Moderation} => {StateOfPost.Published}]");
            }
            else
            {
                post.State = new MiddleState(post);
                Console.WriteLine($"Change state [{StateOfPost.Moderation} => {StateOfPost.Middle}]");
            }
        }
    }
}
