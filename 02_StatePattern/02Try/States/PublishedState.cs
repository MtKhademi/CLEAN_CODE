using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._02Try.States
{
    internal class PublishedState : IStatePost
    {
        private readonly Post post;

        public PublishedState(Post post)
        {
            this.post = post;
        }

        public void Publish()
        {
            Console.WriteLine($"already state is [{StateOfPost.Published}]");
        }
    }
}
