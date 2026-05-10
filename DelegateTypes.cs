// Func<T>: Returns a value. The last type parameter is always the return type. Accepts total of 17 parameters.
// Action<T>: Returns nothing (void). Just does something. Accepts 16 parameters.
// Predicate<T>: Returns a bool. Tests whether something is true. Takes exactly one input.
// Predicate<T> is same as Func<T, bool>. Predicate is old. 

namespace IntroApp
{
    internal class DelegateTypesApp
    {
        internal void DelegateTypes()
        {
            // Func
            Func<string, int, string> Print = (name, age) => $"{name} is {age} years old";
            Console.WriteLine($"{Print("Adam", 24)}");

            // Action
            void SendEmail(string msg) => Console.WriteLine($"Email: {msg}");
            void SendSMS(string msg) => Console.WriteLine($"SMS: {msg}");
            void Log(string msg) => Console.WriteLine($"Logger: {msg}");

            Action<string> notify = SendEmail;
            notify += SendSMS;
            notify += Log;

            notify("Server is down!");

            // Predicate
            List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            void Where(List<int> nums, Predicate<int> condition)
            {
                foreach (int n in nums)
                    if (condition(n))
                        Console.Write(n + " ");
                Console.WriteLine();
            }

            Where(nums, n => n % 2 == 0);
            Where(nums, n => n % 2 != 0);
        }
    }
}
