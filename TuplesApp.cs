// tuples are value types
// The default names of tuple fields are Item1, Item2, Item3, and so on.
// One of the most common use cases for tuples is as a method return type. See example below.

namespace IntroApp
{
    internal class TuplesApp
    {
        internal void Tuples()
        {
            (double Sum, int Count) t1 = (4.5, 3); // named tuple
            Console.WriteLine($"Sum of {t1.Count} elements is {t1.Sum}.");

            (double, int) t2 = (4.5, 3); // shorthand
            Console.WriteLine($"Tuple with elements {t2.Item1} and {t2.Item2}.");

            // var is telling the compiler to figure out the type on its own

            // couple of other ways of creating tuples
            var t3 = (x: 3, y: 2);
            Console.WriteLine($"x = {t3.x}, y = {t3.y}");

            var t4 =
            (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18,
            19, 20, 21, 22, 23, 24, 25, 26);
            Console.WriteLine(t4.Item26);

            var a = 1;
            var t5 = (a, b: 2, 3);
            Console.WriteLine($"The 1st element is {t5.Item1} (same as {t5.a}).");
            Console.WriteLine($"The 2nd element is {t5.Item2} (same as {t5.b}).");
            Console.WriteLine($"The 3rd element is {t5.Item3}.");
        }

        // method returning a tuple
        internal (string favFood, string favDrink) getFavFoodDrink()
        {
            Console.WriteLine("What's your favourite food? ");
            string favFood = Console.ReadLine();

            Console.WriteLine("What's your favourite drink? ");
            string favDrink = Console.ReadLine();

            return (favFood, favDrink);
        }
    }
}
