namespace _1243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("===================");
                Console.WriteLine("Welcome to Calculator 3000!");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("===================");
                Console.Write("Please enter which option you'd like to use: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("You've selected Addition.");
                    Addition();
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("You've selected Subtraction.");
                    Subtraction();
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("You've selected Multiplication.");
                    Multiplication();
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("You've selected Division.");
                    Division();
                }
            }

            static void Addition()
            {
                Console.Write("Input the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Your answer is: ");
                Console.Write(x + y);
            }

            static void Subtraction()
            {
                Console.Write("Input the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Your answer is: ");
                Console.Write(x - y);
            }

            static void Multiplication()
            {
                Console.Write("Input the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Your answer is: ");
                Console.Write(x * y);
            }

            static void Division()
            {
                Console.Write("Input the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("Your answer is: ");
                Console.Write(x / y);
            }
        }
    }
}
