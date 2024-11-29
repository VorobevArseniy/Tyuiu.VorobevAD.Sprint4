using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task5.V6.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task5V6
{
	public int[,] Calculate(int[,] matrix)
	{
		int[,] newMatrix = matrix;
		for (int i = 0; i < matrix.GetLength(0); ++i)
		{
			for (int j = 0; j < matrix.GetLength(1); ++j)
			{
				if (matrix[i, j] > 0) newMatrix[i, j] = 1;
			}
		}

		return newMatrix;

		throw new NotImplementedException();
	}
}

