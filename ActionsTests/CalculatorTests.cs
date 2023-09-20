using Actions.Interfaces;
using Actions.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActionsTests
{
	[TestClass]
	public class CalculatorTests
	{
		private ICalculator _calculator;

		[TestInitialize]
		public void Init()
		{
			_calculator = new Calculator();
		}

		[TestMethod]
		public void Calculate_MultipliesBy3_GivenIntegerInput()
		{
			// Arrange
			int input = new Random().Next();

			// Act
			int result = _calculator.CalculateMagic(input);

			// Assert
			Assert.AreEqual(input * 3, result);
		}
	}
}
