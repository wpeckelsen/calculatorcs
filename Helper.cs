namespace calculatorcs
{

    public static class Helpers
    {


        public static double Plus(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine("double: ");
            return sum

            ;
        }
        public static double Average(params double[] numbers)
        {
            double result;
            double sum = 0;

            foreach (double number in numbers)
            {
                sum += number;
            }
            result = sum / numbers.Length;
            return result;
        }


        // to do, make new general error

    }

}