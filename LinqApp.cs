// Language Integrated Query    
// qeury data from various sources. Supports databases, collections, XML, and In-Memory objects.
// Take a look at this: https://dotnettutorials.net/wp-content/uploads/2019/04/How-linq-works.png
// Which means, one query syntax, you can just do anything with data no matter where it comes from.

// LINQ Providers: are components that enable querying against a specific data source using the LINQ syntax in .NET.
// They do the translation work.

// LINQ has two different syntax - query and method syntax.
// https://dotnettutorials.net/wp-content/uploads/2019/04/c-users-pranaya-pictures-linq-query-syntax-png.png
// https://dotnettutorials.net/wp-content/uploads/2019/04/c-users-pranaya-pictures-linq-method-syntax-png.png

// IEnumerable (in-memory objects) and IQueryable (external sources)

// extension methods: https://arc.net/l/quote/ayxeyviy

namespace IntroApp
{
    internal class LinqApp
    {
        internal void Linq()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // query syntax
            var evens = from num in numbers       // data source
                        where num % 2 == 0      // condition
                        select num;              // selection

            foreach (int even in evens)
            {
                Console.Write(even + " ");
            }

            // method syntax
            var odds = numbers.Where(num => num % 2 != 0).ToList();

            Console.WriteLine();
            foreach (int odd in odds)
            {
                Console.Write(odd + " ");
            }
        }
    }
}
