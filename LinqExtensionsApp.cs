namespace IntroApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{{ Id: {Id}, Name: {Name}, Category: {Category}, Price: {Price}, Stock: {Stock} }}";
        }
    }


    internal class LinqExtensionsApp
    {
        internal void LinqExtensions()
        {
            var collection = new List<Product>
            {
                new Product { Id = 1, Name = "Apple",    Category = "Fruit",     Price = 1.5,  Stock = 100 },
                new Product { Id = 2, Name = "Banana",   Category = "Fruit",     Price = 0.8,  Stock = 0   },
                new Product { Id = 3, Name = "Carrot",   Category = "Vegetable", Price = 1.2,  Stock = 50  },
                new Product { Id = 4, Name = "Broccoli", Category = "Vegetable", Price = 2.5,  Stock = 30  },
                new Product { Id = 5, Name = "Mango",    Category = "Fruit",     Price = 3.0,  Stock = 20  },
                new Product { Id = 6, Name = "Spinach",  Category = "Vegetable", Price = 1.8,  Stock = 0   },
                new Product { Id = 7, Name = "Grapes",   Category = "Fruit",     Price = 4.0,  Stock = 15  },
                new Product { Id = 8, Name = "Potato",   Category = "Vegetable", Price = 0.5,  Stock = 200 },
            };

            //.where with FirstOrDefault
            var product5 = collection.Where(item => item.Id == 5).FirstOrDefault(); // note that FirstOrDefault() returns only one object here
                                                                                    // otherwise we get a collection we should loop through
            Console.WriteLine($"Product 5 is: {product5}");
            Console.WriteLine();

            // select - get only some columns
            // get unique categories
            var productCategories = collection.Select(item => item.Category).Distinct();
            foreach (var category in productCategories)
                Console.Write(category + " ");

            Console.WriteLine();
            Console.WriteLine();

            // order by
            var sorted = collection.OrderBy(item => item.Price);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // aggregation - group by + aggregate function
        }
    }
}
