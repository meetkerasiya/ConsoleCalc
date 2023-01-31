namespace ConsoleCalc
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMsg = "given operation was out of the range of valid values.";

        public string Operation { get; }

        
        public CalculationOperationNotSupportedException()
            : base(DefaultMsg)
        {
        }

        
        public CalculationOperationNotSupportedException(Exception innerException)
            : base(DefaultMsg, innerException)
        {
        }

        
        public CalculationOperationNotSupportedException(string message,
            Exception innerException) : base(message, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string operation)
            : base(DefaultMsg) => Operation = operation;

       
        public CalculationOperationNotSupportedException(string operation, string message)
            : base(message) => Operation = operation;

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }

            return base.ToString() + Environment.NewLine + $" operation: {Operation} is not supported";
        }
    }
}
