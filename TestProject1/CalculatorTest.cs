namespace TestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Plus_ValidNum_TwoNumPlus()
        {
            int Num1 = 4;
            int Num2 = 5;
            int expectedResult = Num1 + Num2;
        }
    }
}