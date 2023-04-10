namespace OOP_Lab6.BehavioralPatternExample;

public abstract class SortingStrategy : ISortingStrategy
{
	protected abstract void Sort<T>(T[] array, int start, int end) where T : IComparable<T>;

	public void Sort<T>(T[] array) where T : IComparable<T> => Sort(array, 0, array.Length - 1);
}
