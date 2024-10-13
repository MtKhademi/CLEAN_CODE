using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._03Try
{
    internal static class Used
    {
        public static void UsedExample()
        {
            // ABSTRACTION
            Console.WriteLine("==================== TRY 03 =================");

            var editor = new Editor();
            Console.WriteLine(editor);


            editor.SetTitle("Hi");
            Console.WriteLine(editor);

            editor.SetContent("Havij");
            Console.WriteLine(editor);

            editor.SetTitle("Chetori");
            Console.WriteLine(editor);

            editor.Undo();
            Console.WriteLine(editor); // Hi Havij **** Chetori Havij

            editor.Undo();
            Console.WriteLine(editor);

            editor.Undo();
            Console.WriteLine(editor);

            Console.WriteLine("=============================================");

        }
    }
}
