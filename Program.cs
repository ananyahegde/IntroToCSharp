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
        }
    }
}
