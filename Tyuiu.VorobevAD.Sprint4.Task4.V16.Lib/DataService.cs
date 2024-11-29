using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task4.V16.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task4V16
{
	public int[,] Calculate(int[,] matrix)
	{
		int[,] newMatrix = matrix;

		for (int i = 0; i < matrix.GetLength(0); ++i)
		{
			for (int j = 0; j < matrix.GetLength(0); ++j)
			{
				if (matrix[i, j] % 2 == 0) newMatrix[i, j] = 1;
			}
		}
		return newMatrix;
		throw new NotImplementedException();
	}
}
