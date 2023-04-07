using System.Net.Http.Headers;

namespace OOP_Lab6.BehavioralPatternExample;

public static class SortingHelper
{
	public static void Swap<T>(T[] array, int i, int j) => (array[i], array[j]) = (array[j], array[i]);

	public static bool IsSorted<T>(T[] array, int start, int end) where T : IComparable<T>
	{
		for (int i = start; i < end; i++)
		{
			if (array[i].CompareTo(array[i + 1]) > 0)
			{
				return false;
			}
		}
		return true;
	}

	public static int[] Generate(int count, int min, int max)
	{
		var rand = new Random();
		var array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = rand.Next(min, max);
		}
		return array;
	}
}
