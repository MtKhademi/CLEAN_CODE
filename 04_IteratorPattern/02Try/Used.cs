namespace _04_IteratorPattern._02Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 03 =================");

            var list = new ShoopingList();
            list.Push("Khiar");
            list.Push("Havij");
            list.Push("Goje");

            list.ShowItems();

            Console.WriteLine("=============================================");

        }
    }
}
