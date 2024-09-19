namespace calculatorcs
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ++++ CALCULATOR ++++ ");

            Console.WriteLine("write 1 for average, write 2 for operations");
            string[] validChoices = ["1", "2"];

            while (true)
            {
                string choice = Console.ReadLine();
                if (validChoices.Contains(choice))
                {

                    if (choice == "1")
                    {
                        // average
                        List<double> capturedEntries = new List<double>();
                        double entryAsDouble;

                        while (true)
                        {
                            Console.WriteLine("Enter number, or '#' to calculate the average");
                            string input = Console.ReadLine();


                            if (input == "#")
                            {
                                if (capturedEntries.Count > 0)
                                {
                                    double result = Helpers.Average(capturedEntries.ToArray());
                                    Console.WriteLine("average: " + result);
                                }
                                else
                                {
                                    Console.WriteLine("not enough numbers to calculate average.");
                                }

                                break;
                            }
                            else
                            {
                                if (double.TryParse(input, out entryAsDouble))
                                {
                                    Console.WriteLine("valid.");
                                    capturedEntries.Add(entryAsDouble);
                                }
                                else
                                {
                                    Console.WriteLine("invalid.");
                                }
                            }

                        }
                    }
                    else
                    {
                        // operations
                        Console.WriteLine("add first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        string[] validOperators = ["+", "-", "*", "/"];
                        string op = "";

                        while (true)
                        {

                            Console.WriteLine("add operator +  -  *  /   ");
                            string input = Console.ReadLine();

                            if (validOperators.Contains(input))
                            {
                                op = input;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("invalid!");
                            }

                        }


                        Console.WriteLine("add second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        try
                        {
                            Calculator calculator = new Calculator(num1, num2, op);
                            double result = calculator.PerformCalc();
                            // double result = Calculator.PerformCalc(num1, num2, op);
                            Console.WriteLine("Result: " + result);
                        }

                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("error. " + ex.Message);
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}