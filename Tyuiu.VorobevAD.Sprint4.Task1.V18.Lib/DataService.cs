﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevAD.Sprint4.Task1.V18.Lib;

public class DataService : ISprint4Task1V18
{
	public int Calculate(int[] array)
	{
		int acc = 0;
		for (int i = 0; i < array.Length; ++i)
		{
			if (i % 2 != 0) acc += array[i];
		}

		return acc;

		throw new NotImplementedException();
	}
}
