using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task6.V3.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task6V3
{
	public int Calculate(string[] array)
	{
		return array.Count(e => e.Length < 6);
		throw new NotImplementedException();
	}
}
