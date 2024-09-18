namespace calculatorcs
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ++++ CALCULATOR ++++ ");
     

            Console.WriteLine("add first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            

            string[] validOperators = { "+", "-", "*", "/" };
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

            // catch (InvalidOperationException ex)
            // {
            //     Console.WriteLine("error. " + ex.Message);
            // }
        }


    }
}