using WinForms_Calculator;

namespace WinForms_Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange：準備
            CCalculator calculator = new CCalculator();

            // Act：執行
            double result = calculator.Calculate(2, 3, "+");

            // Assert：驗證
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            CCalculator calculator = new CCalculator();

            // 驗證「除以 0 時會丟出 DivideByZeroException」
            Assert.Throws<DivideByZeroException>(
                () => calculator.Calculate(10, 0, "/")
            );
        }
    }
}
