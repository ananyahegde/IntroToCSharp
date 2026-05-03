namespace IntroApp
{
    internal class ListsApp
    {
        internal void ShowListExample()
        {
            List<string> names = ["Alexander", "Xavier"];
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // add items
            names.Add("Maria");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // get items by index
            Console.WriteLine($"My name is {names[0]}.");

            // counting number of items.
            Console.WriteLine($"The list has {names.Count} items.");

            // sorting
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

            // find index of an element
            var indexOfXavier = names.IndexOf("Xavier");
            var indexOfFelipe = names.IndexOf("Felipe");

            Console.WriteLine($"The name {names[indexOfXavier]} is at index {indexOfXavier}");
            Console.WriteLine($"IndexOfFelipe = {indexOfFelipe}");

        }
    }
}
