// Extension members enable you to "add" methods to existing types.
// Extension methods are static methods, but they're called as if they were instance methods on the extended type.
// i.e., called by using instance method syntax.

// #1: Note that, the documentation gives you the new syntax which is for c# version 14 or above I think. For anything below
// you have to use the older syntax with `this`.


namespace IntroApp
{
    internal class ExtensionsApp
    {
        internal void Extensions()
        {
            int[] numbers = [10, 45, 15, 39, 21, 26];
            IOrderedEnumerable<int> result = numbers.OrderBy(g => g);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }

    // defining our own extention method (#1)
    public static class MyExtensions
    {
        public static int CountWords(this string str)
        {
            return str.Split(' ').Length;
        }
    }
}
