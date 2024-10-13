using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._01Try
{
    internal class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }


        public StateOfPost State { get; set; } = StateOfPost.Draft;
        public UserRole User { get; set; } = UserRole.Writter;

        public void Pulish()
        {

            if (State == StateOfPost.Draft)
            {
                State = StateOfPost.Moderation;
                Console.WriteLine($"Change state [{StateOfPost.Draft} => {StateOfPost.Moderation}]");
            }
            else if (State == StateOfPost.Moderation)
            {
                if (User == UserRole.Admin)
                {
                    State = StateOfPost.Published;
                    Console.WriteLine($"Change state [{StateOfPost.Moderation} => {StateOfPost.Published}]");
                }
                else if (User == UserRole.Reader)
                {
                    State = StateOfPost.Middle;
                    Console.WriteLine($"Change state [{StateOfPost.Moderation} => {StateOfPost.Middle}]");
                }
                else
                {
                    Console.WriteLine("You don't have permission");
                }
            }
            else if (State == StateOfPost.Middle)
            {
                if (User == UserRole.Admin)
                {
                    State = StateOfPost.Published;
                    Console.WriteLine($"Change state [{StateOfPost.Moderation} => {StateOfPost.Published}]");
                }
                else
                {
                    Console.WriteLine("You don't have permission");
                }
            }
            else
            {
                Console.WriteLine($"already state is [{StateOfPost.Published}]");
            }
        }

    }
}
