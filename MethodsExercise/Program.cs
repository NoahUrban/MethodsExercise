namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            int num1 = 10;
            int num2 = 2;
            int add = Add(num1, num2);
            int sub = Sub(num1, num2);
            int mult = Mult(num1, num2);
            int div = Div(num1, num2);

            // Exercises
            CreateStory();

            Console.WriteLine();

            Console.WriteLine($"{num1} + {num2} = {add}");
            Console.WriteLine($"{num1} - {num2} = {sub}");
            Console.WriteLine($"{num1} * {num2} = {mult}");
            Console.WriteLine($"{num1} / {num2} = {div}");

        }

        // Full Name Method
        public static string CreateStory()
        {
            Clear();

            Console.WriteLine("Enter your first name...");
            string first = Console.ReadLine();
            Clear();

            Console.WriteLine("Enter your last name...");
            string last = Console.ReadLine();
            Clear();

            string fullName = first + " " + last;

            Console.WriteLine("Enter your favorite color...");
            string color = Console.ReadLine();
            Clear();

            Console.WriteLine("Enter your Age...");
            string age = Console.ReadLine();
            Clear();

            Console.WriteLine("Enter your favorite food...");
            string meal = Console.ReadLine();
            Clear();

            string story = $"{fullName} is {age}, loves eating {meal}, and the color {color}.";

            Console.WriteLine(story);
            return story;
        }

        // Add
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;

            Console.WriteLine($"{sum}");
            return sum;
        }

        // Subtract
        public static int Sub(int num1, int num2)
        {
            int sub = num1 - num2;

            Console.WriteLine($"{sub}");
            return sub;
        }

        // Multiply
        public static int Mult(int num1, int num2)
        {
            int mult = num1 * num2;

            Console.WriteLine($"{mult}");
            return mult;
        }

        // Divide
        public static int Div(int num1, int num2)
        {
            int div = num1 / num2;

            Console.WriteLine($"{div}");
            return div;
        }

        // Clear Shortcut
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
