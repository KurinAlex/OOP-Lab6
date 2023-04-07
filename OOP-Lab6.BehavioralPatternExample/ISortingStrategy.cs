namespace OOP_Lab6.BehavioralPatternExample;

public interface ISortingStrategy
{
	void Sort<T>(T[] array, int start, int end) where T : IComparable<T>;
}
