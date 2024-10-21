namespace _06_TemplateMethodPattern._04Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 04 =================");

            //var tea = new Tea();
            //tea.Make();

            //var cofe = new Cofee();
            //cofe.Make();

            var maker = new DrinkMaker(new Tea());
            maker.Prepare();


            maker = new DrinkMaker(new Cofee());
            maker.Prepare();

            Console.WriteLine("=============================================");

        }
    }
}
