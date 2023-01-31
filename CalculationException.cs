namespace ConsoleCalc
{
    public class CalculationException : Exception
    {
        private const string DefaultMsg = "An error occurred during calculation. Ensure that the operator is supported and that the values are within the valid ranges for the requested operation.";

        public CalculationException() : base(DefaultMsg)
        {
        }

        public CalculationException(string message) : base(message)
        {
        }


        public CalculationException(Exception innerException) : base(DefaultMsg, innerException)
        {
        }

        public CalculationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
