namespace OOP_Lab6.BehavioralPatternExample;

public class QuickSort : SortingStrategy
{
	private static int Partition<T>(T[] array, int start, int end) where T : IComparable<T>
	{
		T pivot = array[start + (end - start) / 2];
		int i = start;
		int j = end;

		while (true)
		{
			while (array[i].CompareTo(pivot) < 0)
			{
				i++;
			}
			while (array[j].CompareTo(pivot) > 0)
			{
				j--;
			}
			if (i >= j)
			{
				return j;
			}
			SortingHelper.Swap(array, i++, j--);
		}
	}

	protected override void Sort<T>(T[] array, int start, int end)
	{
		if (start < end)
		{
			int p = Partition(array, start, end);
			Sort(array, start, p);
			Sort(array, p + 1, end);
		}
	}
}
