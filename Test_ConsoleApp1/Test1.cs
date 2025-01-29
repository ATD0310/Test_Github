namespace Test_ConsoleApp1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_Add()
        {
            // Arrange
            decimal a = 2;
            decimal b = 3;

            // Act
            decimal result = Calculator.Add(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_Divide()
        {
            // Arrange
            decimal a = 6;
            decimal b = 3;

            // Act
            decimal result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_DivideByZero()
        {
            // Arrange
            decimal a = 5;
            decimal b = 0;

            // Act
            Calculator.Divide(a, b);

            // Assert (handled by ExpectedException)
        }
    }
}
