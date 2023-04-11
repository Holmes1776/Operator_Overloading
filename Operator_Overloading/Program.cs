using System.Diagnostics;

namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }

        // Overload unary operators ++ and -- 
        public static Calculator operator ++(Calculator item)
        {
            item.number++;
            return item;
        }
        public static Calculator operator --(Calculator item) 
        {
            item.number--;
            return item;
        }

        // Overload Comparison Operators > and <
        public static bool operator >(Calculator left, Calculator right)
        {
            bool condition = false;
            if (left.number > right.number) 
            {
                condition = true;
            }
            return condition;
        }
        public static bool operator <(Calculator left, Calculator right) 
        {
            bool condition = false;
            if (left.number < right.number) 
            {
                condition = true;
            }
            return condition;
        }

        // Overload Binary Operators + and -
        public static Calculator operator +(Calculator left, Calculator right)
        {
            Calculator item = new Calculator();
            item = left + right;
            return item;
        }
        public static Calculator operator -(Calculator left, Calculator right)
        {
            Calculator item = new Calculator();
            item = left - right;
            return item;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            // create object array
            Calculator[] numbers = new Calculator[10];
            // place random numbers into array and print values
            Console.Write("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); // creates the object
                numbers[i].number = r.Next(1, 100);  // places a value in the object
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();
            // if divisible by 2, add 1 to value using operator ++ method
            // otherwise subtract 1 from value using operator -- method
            Console.Write("New Numbers +1 or -1= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    // Code goes here
                    numbers[i].number++;
                }
                else
                {
                    numbers[i].number--;
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object to add
            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
            // Using operator +, add numToAdd.number to each element in the array
            // Print the results
            Console.Write($"Numbers + {numToAdd.number} = ");

            // Code goes here
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i].number += numToAdd.number;
                Console.Write($"{numbers[i].number} ");
            }

            Console.WriteLine();

            // random Calculator object to subtract
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            // Using operator -, subtract numToSub.number from each element in the array
            // Print the results
            Console.Write($"Numbers - {numToSub.number} = ");

            // Code goes here
            for (int i = 0; i<numbers.Length;i++)
            {
                numbers[i].number -= numToSub.number;
                Console.Write($"{numbers[i].number} ");
            }

            Console.WriteLine();

            // random Calculator object for comparison
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            // Using operator > and operator <, compare each element to numToCompare.number
            // print if the element is higher, lower or equal to the number you are comparing to
            Console.WriteLine($"Numbers above or below {numToCompare.number}");

            // Code goes here
            for (int i = 0; i<numbers.Length; i++) 
            {
                bool higher = numbers[i].number > numToCompare.number;
                bool lower = numbers[i].number < numToCompare.number;
                if (higher)
                {
                    Console.WriteLine($"{numbers[i].number} is higher.");
                }
                else if (lower)
                {
                    Console.WriteLine($"{numbers[i].number} is lower.");
                }
                else
                {
                    Console.WriteLine($"{numbers[i].number} is equal.");
                }
            }
        }
    }
}