using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task0.V29.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task0V29
{
	public int GetSumOddArrEl(int[] array)
	{
		int acc = 0
		foreach (int i in array)
		{
			if (i % 2 != 0) acc += i;
		}
		return acc;
		throw new NotImplementedException();
	}
}
