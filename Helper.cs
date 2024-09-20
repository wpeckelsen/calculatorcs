namespace calculatorcs
{

    public static class Helpers
    {

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


        public class InvalidEntryException : Exception
        {
            public InvalidEntryException() : base("invalid entry!")
            {

            }

            public InvalidEntryException(string message) : base(message)
            {

            }
        }


        // hash

        // Dictionary<string, int> ages = new Dictionary<string, int>();

        

    }

}