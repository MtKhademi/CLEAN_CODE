namespace _07_ObserverPattern._01Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 01 =================");

            List<IReload> lstComponents = [new Chart(), new Calculation()];

            var dt = new DataSource();
            dt.Change([1, 2, 3]);

            lstComponents.ForEach(com => com.Render(dt.Items));

            dt.Change([1, 2, 3, 4, 5, 6]); // change data
            lstComponents.ForEach(com => com.Render(dt.Items));

            lstComponents.Add(new Chart());
            lstComponents.ForEach(com => com.Render(dt.Items));


            Console.WriteLine("=============================================");

        }
    }
}
