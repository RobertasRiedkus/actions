using Actions.Interfaces;

namespace Actions.Services;

public class Calculator : ICalculator
{
	public int CalculateMagic(int input)
	{
		return input * 3;
	}
}
