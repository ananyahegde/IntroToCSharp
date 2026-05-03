// Read:
//  https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
//  https://www.reddit.com/r/Cplusplus/comments/1nl2b8r/struct_vs_class_when_do_you_use_which_one_and_why/

// A structure type (or struct type) is a value type that can encapsulate data and related functionality.
//

namespace IntroApp
{
    internal class StructsApp
    {
        internal struct Point
        {
            // fields
            internal double X;
            internal double Y;

            // constructor
            internal Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
