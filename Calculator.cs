namespace ConsoleCalc
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation =
                operation ?? throw new ArgumentNullException(nameof(operation));

            

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("...logging...");
                   

            }
            
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}
}
