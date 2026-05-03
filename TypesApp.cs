/// Sauce:
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
/// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
/// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing

namespace IntroApp

{
  internal class TypesApp
  {
    /// Value type → each variable gets its own copy of the data.
    /// Reference type → one piece of data, multiple variables pointing to it.

    internal void ValueAndReferenceTypes()
    {
      // value types
      int a = 123;
      int b = a; // b gets a copy
      b = 456;

      Console.WriteLine($"Value of a: {a}");
      Console.WriteLine($"Value of b: {b}");


      // reference types
      int[] arr1 = {1, 2, 3};
      int[] arr2 = arr1;
      arr2[2] = 99;

      Console.WriteLine($"Value of arr1[2]: {arr1[2]}");
      Console.WriteLine($"Value of arr2[2]: {arr2[2]}");


      // string is an exception, cause its immutable.
      // you can never modify an existing string in place. Every operation that "changes" a string creates a brand new one. 
      // This makes it behave like a value type in most everyday situations, but under the hood it's still a reference type.

      string c = "h";
      string d = c;
      d += "ello";

      Console.WriteLine($"Value of c: {c}");
      Console.WriteLine($"Value of d: {d}");
    }

    // Implicit conversions: No special syntax is required because the conversion always succeeds and no data is lost. e.g., smallint -> bigint
    // Explicit conversions (casts): Explicit conversions require a cast expression (e.g., int b = (int) x).

    internal void TypeConversion()
    {
      // implicit conversion
      int a = 12;
      float b = a; // no complaints from the compiler

      Console.WriteLine($"b = {b}");

      // explicit conversion
      double c = 1234.567;
      int d = (int) c;

      Console.WriteLine($"d = {d}");
    }

    // Boxing is the process of converting a value type to the type `object`.
    // This is different from type conversion because it moves the data from the stack to heap.
    // Type conversion doesn't change where the data lives. Boxing/unboxing does.

    internal void BoxingAndUnboxing()
    {
      int k = 1234;
      object o = k; // boxing

      o = 456;
      int x = (int) o; // unboxing
      
      // example of how you might wanna use it
      List<object> mixedList = [];

      mixedList.Add("A");
      for (int i=1; i < 5; i++)
      {
        mixedList.Add(i);
      }

      mixedList.Add("B");
      for (int i=5; i < 11; i++)
      {
        if (i == 8)
        {
          mixedList.Add("C");
        }
        mixedList.Add(i);
      }

      Console.WriteLine($"Type of mixedList: {mixedList}");

      var sum = 0;
      for (var j = 1; j < 5; j++)
      {
        // sum += mixedList[j]; // Operator '+=' cannot be applied to operands of type 'int' and 'object'
        sum += (int) mixedList[j]; 
      }
      Console.WriteLine($"Sum = {sum}");
    }
  }
}
