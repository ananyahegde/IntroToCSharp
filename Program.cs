namespace IntroApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypesApp types = new TypesApp();
            // types.ValueAndReferenceTypes();
            // types.TypeConversion();
            // types.BoxingAndUnboxing();

            NullHandlingApp nullhandling = new NullHandlingApp();
            // nullhandling.NullableVariables();
            // nullhandling.ConvertToNullableType();
            // nullhandling.NullCollation();

            LimitsApp limits = new LimitsApp();
            // limits.ShowLimits();

            TuplesApp tuples = new TuplesApp();
            // tuples.Tuples();
            // (string favFood, string favDrink) = tuples.getFavFoodDrink();
            // Console.WriteLine($"Your favourite food and drink is {favFood} and {favDrink}");

            StructsApp structs = new StructsApp();
            // StructsApp.Point p = new StructsApp.Point(3.3, 4.4);
            // Console.WriteLine($"{p.X}, {p.Y}");

            ListsApp lists = new ListsApp();
            // lists.ShowListExample();

            Account account = new Account("1234567890", "ABC", DateTime.Parse("1990-05-15"), "9999-888-777", 0);
            // Console.WriteLine(account);

            ExceptionHandlingApp exceptionHandling = new ExceptionHandlingApp();
            // exceptionHandling.Exceptions();

            ExtensionsApp extensionsApp = new ExtensionsApp();
            // extensionsApp.Extensions();

            string myString = "Ba-dump. Ba-dump. Ba-dump. The first sound that greeted her when she awoke was her own heartbeat. The second sound was a squealing mechanical whir. Her eyes (so heavy, so tired) drifted to the source of the noise: robotic appendages with drills and pliers and other tools affixed to the end of them. They retreated from her to metal poles that surrounded her bed. A bed?";

            int count = myString.CountWords();
            // Console.WriteLine(count);

            // Delegate p = new Delegate();
            LinqApp linqApp = new LinqApp();
            // linqApp.Linq();

            LinqExtensionsApp linqExtensionsApp = new LinqExtensionsApp();
            // linqExtensionsApp.LinqExtensions();

            DelegateTypesApp delegateTypesApp = new DelegateTypesApp();
            delegateTypesApp.DelegateTypes();

        }
    }
}
