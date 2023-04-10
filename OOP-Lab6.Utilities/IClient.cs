namespace OOP_Lab6.Utilities;

public interface IClient
{
	string PatternType { get; }
	string PatternName { get; }

	void Main();
}