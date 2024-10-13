using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StatePattern._01Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 01 =================");

            var post = new Post();
            post.Pulish(); // moderation

            post.Pulish(); // permission

            post.User = UserRole.Reader;

            post.Pulish(); //publish

            post.Pulish(); // nothing

            Console.WriteLine("=============================================");

        }
    }
}
