namespace IntroApp

{
  internal class NullHandlingApp
  {
    // you cannot assign NULL to a value type variables
    // but you can can assign a NULL value to any Reference type variables

    internal void NullableVariables()
    {
      // int x = null; // throws error
      // this is fine since it's a reference type, although it throws a warning
      string y = null;
      int[] arr = null;

      Console.WriteLine($"Value of y is: {y}");
      Console.WriteLine($"Value of arr is: {arr}");
    }

    internal void ConvertToNullableType()
    {
      Nullable<int> x1 = null; // or
      int ?x2 = null;

      Console.WriteLine($"x1 = {x1}");
      Console.WriteLine($"x2 = {x2}");
    }

    // null-coalescing operator that is used to define the default value for nullable reference or value types.
    internal void NullCollation()
    {
      Console.WriteLine("Hello! What's your name?");

      string name = Console.ReadLine();
      if (name == "")
      {
        name = null;
      }
      string yourName = name??"Beautiful Person";

      Console.WriteLine($"Hello, {yourName}");
    }
  }
}
