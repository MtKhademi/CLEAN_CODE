using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Memento._02Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 02 =================");

            var editor = new Editor();
            History history = new History(editor);
            history.Backup();
            Console.WriteLine(editor);


            history.Backup();
            editor.SetTitle("Hi");
            Console.WriteLine(editor);

            history.Backup();
            editor.SetContent("Havij");
            Console.WriteLine(editor);

            history.Backup();
            editor.SetTitle("Chetori");
            Console.WriteLine(editor);

            history.Undo();
            Console.WriteLine(editor); // Hi Havij **** Chetori Havij

            history.Undo();
            Console.WriteLine(editor);

            history.Undo();
            Console.WriteLine(editor);

            Console.WriteLine("=============================================");

        }
    }
}
