using System.Net.Http.Headers;
using Mathematics;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {   //area
            double area = AdvMath.CalcArea(10, 5);
            Console.WriteLine("Area of Rectangle: {0}", area);

            //avg
            List<double> numbers = new List<double> { 2.5, 3.7, 4.8 };
            double average = AdvMath.CalcAvg(numbers);
            Console.WriteLine("\nAverage of Numbers: {0}", average);

            //squared
            double squared = AdvMath.Squared(3);
            Console.WriteLine("Squared Value: {0}\n", squared);

            //pythag
            double resultPythagoras = AdvMath.CalcPythagorean(5, 12);
            Console.WriteLine("Pythagorean Result: {0}", resultPythagoras);

            try 
            {
                string operation;
                int operand1, operand2;
                ValidateArguments(args, out operation, out operand1, out operand2);
                BasicMath basicMath = new BasicMath();
                double result;
                string operationDesc;
                switch (operation)
                {
                    case "+":
                        {
                            result = basicMath.AddNumbers(operand1, operand2);
                            operationDesc = "Plus";
                            break;
                        }
                    case "-":
                        {
                            result = basicMath.SubNumbers(operand1, operand2);
                            operationDesc = "Minus";
                            break;
                        }
                    case "*":
                        {
                            result = basicMath.MultNumbers(operand1, operand2);
                            operationDesc = "Times";
                            break;
                        }
                    case "/":
                        {
                            result = basicMath.DivNumbers(operand1, operand2);
                            operationDesc = "Divided By";
                            break;
                        }
                    default:
                        {
                            throw new Exception("An unexpected error occured");
                            break;
                        }
                }
                Console.WriteLine($"{operand1} {operationDesc} {operand2} is equal to {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[ERROR]Something went wrong: {ex.Message.ToString()}");
            }           
        }

        private static void ValidateArguments(string[] args, out string operation, out int operand1, out int operand2)
        {
            if(args.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Not enough arguments were passed to perform the operation");
            }
            if (args[0] != "+" && args[0] != "-" && args[0] != "*" && args[0] != "/")
            {
                throw new ArgumentException("First Argument Must be math Operator!!!");
            }
            if(!int.TryParse(args[1], out operand1))
            {
                throw new ArgumentException("Second argument must be a valid int");
            }
            if (!int.TryParse(args[2], out operand2))
            {
                throw new ArgumentException("Third argument must be a valid int");
            }
            operation = args[0];
        }
       
    }
}
