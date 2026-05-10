// note: DivideByZeroException is only thrown for integers
// float (and double) defines special values like +Infinity, -Infinity, and NaN. So result produces Infinity — it does not throw an exception.


namespace IntroApp
{
    internal class ExceptionHandlingApp
    {
        internal void Exceptions()
        {
            try
            {
                int num = int.MaxValue;
                num++; // overflow exception 
                Console.WriteLine("num = " + num);

                Console.WriteLine("Enter a numerator.");
                int num1 = Convert.ToInt32(Console.ReadLine()); // type exception

                Console.WriteLine("Enter the denominator.");
                int num2 = Convert.ToInt32(Console.ReadLine()); // type exception

                var result = num1 / num2; // devide by zero/type excetption
                Console.WriteLine("The final result is " + result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("`num` is too small or too large.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero!");
            }
            catch (Exception e) // general exception
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(e); // for the programmer for debugging
            }
            Console.WriteLine("Exiting Application.");
        }
    }
}
