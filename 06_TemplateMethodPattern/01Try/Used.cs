namespace _06_TemplateMethodPattern._01Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 01 =================");

            var tea = new Tea();
            tea.BoilingWater();
            tea.PurIntoCup();
            tea.Brew();
            tea.AskCustomer();
           
            Console.WriteLine("=============================================");

        }
    }
}
