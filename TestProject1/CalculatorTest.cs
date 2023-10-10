using CalculatorDesktopApplication;

namespace TestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void HandleButtonClick_WhenCurrentNumberIsNotEmpty_ShouldAppendButtonLabel()
        {
            // Arrange
            Calculator calculator = new Calculator();
            calculator.CurrentNumber = "5";
            string buttonLabel = "1";
            string expected = "51";

            // Act
            calculator.HandleButtonClick(buttonLabel);

            // Assert
            Assert.AreEqual(expected, calculator.CurrentNumber);
        }

        [TestMethod]
        public void DecimalToBinary_ConvertsPositiveDecimalToBinary()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int decimalNumber = 42;

            // Act
            string binaryRepresentation = Calculator.DecimalToBinary(decimalNumber);

            // Assert
            Assert.AreEqual("101010", binaryRepresentation);
        }

        [TestMethod]
        public void DecimalToHexadecimal_ConvertsPositiveDecimalToHex()
        {
            // Arrange
            int decimalNumber = 255;

            // Act
            string hexadecimalRepresentation = Calculator.DecimalToHexadecimal(decimalNumber);

            // Assert
            Assert.AreEqual("FF", hexadecimalRepresentation);
        }
    }
}