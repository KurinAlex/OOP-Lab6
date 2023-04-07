namespace OOP_Lab6.BehavioralPatternExample;

public class MergeSort : ISortingStrategy
{
	private static void Merge<T>(T[] array, int start, int middle, int end) where T : IComparable<T>
	{
		int left = start;
		int right = middle + 1;
		T[] tempArray = new T[end - start + 1];
		int index = 0;

		while ((left <= middle) && (right <= end))
		{
			if (array[left].CompareTo(array[right]) < 0)
			{
				tempArray[index] = array[left];
				left++;
			}
			else
			{
				tempArray[index] = array[right];
				right++;
			}

			index++;
		}

		for (int i = left; i <= middle; i++)
		{
			tempArray[index] = array[i];
			index++;
		}

		for (int i = right; i <= end; i++)
		{
			tempArray[index] = array[i];
			index++;
		}

		for (int i = 0; i < tempArray.Length; i++)
		{
			array[start + i] = tempArray[i];
		}
	}

	public void Sort<T>(T[] array, int start, int end) where T : IComparable<T>
	{
		if (start < end)
		{
			int middle = start + (end - start) / 2;
			Sort(array, start, middle);
			Sort(array, middle + 1, end);
			Merge(array, start, middle, end);
		}
	}
}
