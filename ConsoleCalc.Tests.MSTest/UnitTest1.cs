namespace ConsoleCalc.Tests.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var calc = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => calc.Calculate(1, 2, "-"));
        }

        [TestMethod]
        public void ThrowWhenInvalidOperationOperaterCheck()
        {
            var calc = new Calculator();
            var ex=Assert.ThrowsException<CalculationOperationNotSupportedException>(
                ()=>calc.Calculate(1, 2, "+"));
            Assert.AreEqual("+", ex.Operation);
        }        
    }
}