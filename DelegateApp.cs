namespace IntroApp
{
    internal class Delegate
    {
        // Delegate type: any method that takes two ints
        public delegate void MathOp(int a, int b);

        // Holds the currently selected operation
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
