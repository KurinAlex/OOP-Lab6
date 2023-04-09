namespace OOP_Lab6.BehavioralPatternExample;

public interface ISortingStrategy
{
	void Sort<T>(T[] array) where T : IComparable<T>;
}
