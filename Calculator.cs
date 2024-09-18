namespace calculatorcs
{

    public class Calculator
    {
        // public static class Calculator { remove static, because static cannot be instatiated. I need a calculator class instance now

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operator { get; set; }

        public Calculator(double num1, double num2, string op)
        {
            Num1 = num1;
            Num2 = num2;
            Operator = op;
        }


        // public double plus(double num1, double num2)
        // {
        //     double sum = num1 + num2;
        //     Console.WriteLine("double: ");
        //     return sum;
        // }

        public double minus(double num1, double num2)
        {
            double sum = num1 - num2;
            return sum;
        }

        public double times(double num1, double num2){
            double sum = num1 * num2;
            return sum;
        }

        public double divide(double num1, double num2){
            double sum = num1 / num2;
            return sum;
        }



        public double PerformCalc()
        {

            switch (Operator)
            {

                case "+":
                    return Helpers.Plus(Num1, Num2);
                    // plus(Num1, Num2);


                case "-":
                    return minus(Num1, Num2);

                case "*":
                    return times(Num1, Num2);

                case "/":
                    if (Num2 != 0)
                        return divide(Num1, Num2);
                    else throw new DivideByZeroException("cannot divide by 0 !!!");

                default: throw new InvalidOperationException("PerformCalc. invalid operator");
            }
        }

    }
}