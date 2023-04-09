namespace OOP_Lab6.BehavioralPatternExample;

public class InsertionSort : SortingStrategy
{
	protected override void Sort<T>(T[] array, int start, int end)
	{
		for (int i = start; i < end; i++)
		{
			T value = array[i + 1];
			int j = i;
			while (j >= start && value.CompareTo(array[j]) < 0)
			{
				array[j + 1] = array[j];
				j--;
			}
			array[j + 1] = value;
		}
	}
}
