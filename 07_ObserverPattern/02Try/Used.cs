namespace _07_ObserverPattern._02Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 02 =================");
            var dt = new DataSource();

            var c1 = new Chart(dt);
            var c2 = new Calculation(dt);


            dt.Change([1, 2, 3]);

            //dt.Change([1, 2, 3, 4, 5, 6]); // change data

            dt.Update([-1, -2]); // change data


            Console.WriteLine("=============================================");

        }
    }
}
