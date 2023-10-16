
public class Program
{
    //Abstract class 
    public abstract class Calculator
    {
        //Abstract method
        public abstract double Calculate(double a, double b);
    }

    public class Addition : Calculator
    {
        public override double Calculate(double a, double b)
        {
            return a + b;
        }
    }
    public class Subtraction : Calculator
    {
        public override double Calculate(double a, double b)
        {
            return a - b;
        }
    }
    public class Multiplication : Calculator
    {
        public override double Calculate(double a, double b)
        {
            return a * b;
        }
    }
    public class Division : Calculator
    {
        public override double Calculate(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Can not be divided by Zero");
                return 0;
            }
            return a / b;
        }
    }

    public static void Main(string[] args)
    {
        // Initialize the Calculator class
        Calculator cal = null;
        double result = 0;
        bool isContinuo = true;
        while (isContinuo)
        {
            Console.Clear();
            Console.WriteLine("Select one of the following operations:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
            int option;

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
                continue;
            }

            switch (option)
            {
                case 1:
                    cal = new Addition();
                    break;
                case 2:
                    cal = new Subtraction();
                    break;
                case 3:
                    cal = new Multiplication();
                    break;
                case 4:
                    cal = new Division();
                    break;
                case 5:
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    continue;
            }

            Console.WriteLine("Enter the first number");
            double a;

            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Enter the second number");
            double b;

            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            
                continue;
            }

            result = cal.Calculate(a, b);
            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Do you want to continue? (Y/N)");
            string yesNo = Console.ReadLine();

            if (string.Equals(yesNo, "N", StringComparison.OrdinalIgnoreCase))
            {
                isContinuo = false;
            }
           // Console.Clear();
        }
    }
}