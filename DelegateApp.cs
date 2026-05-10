// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
// https://www.reddit.com/r/csharp/comments/t4g7t6/explain_delegates_to_me_like_im_a_child/ (look at the 3rd, long-technical comment)
// A delegate is a type that represents references to methods with a particular parameter list and return type.

// Writing a delegate involves these three steps:
// https://dotnettutorials.net/wp-content/uploads/2022/09/word-image-29911-7-2.png
// then you just use delegate instance instead of a function name to call the method.

// this is a custom delegate example.
namespace IntroApp
{
    internal class Delegate
    {
        // Delegate type: any method that takes two ints
        public delegate void MathOp(int a, int b);

        // Delegate instance Holds the currently selected operation
        private MathOp _op;

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product of {a} and {b} is {a * b}");
        }

        public void Run(MathOp op)
        {
            op(100, 200);
        }

        // Default to Multiply
        public Delegate()
        {
            _op = new MathOp(Multiply);
            Run(_op);

        }
    }
}
