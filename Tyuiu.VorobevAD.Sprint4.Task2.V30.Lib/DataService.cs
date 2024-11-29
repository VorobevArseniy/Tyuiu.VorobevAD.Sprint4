using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task2.V30.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task2V30
{
	public int Calculate(int[] array)
	{
		int acc = 1;

		foreach (int i in array)
		{
			if (i % 2 != 0) acc *= i;
		}

		return acc;
		throw new NotImplementedException();
	}
}
