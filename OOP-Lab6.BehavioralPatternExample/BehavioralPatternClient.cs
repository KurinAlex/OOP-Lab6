using System.Diagnostics;

using OOP_Lab6.Utilities;

namespace OOP_Lab6.BehavioralPatternExample;

public class BehavioralPatternClient : IClient
{
	private static readonly Dictionary<string, (string Description, ISortingStrategy Factory)> s_sorts = new()
	{
		["sm"] = ("is small", new InsertionSort()),
		["st"] = ("need to be sorted stable", new MergeSort()),
		["i"] = ("need to be sorted in place", new QuickSort())
	};

	public string PatternType => "behavioral";
	public string PatternName => "strategy";

	public void Main()
	{
		int count = InputHelper.GetInt32Input("array size", c => c > 0);
		int min = InputHelper.GetInt32Input("min");
		int max = InputHelper.GetInt32Input("max", max => max > min);

		var array = SortingHelper.Generate(count, min, max);

		var strategy = InputHelper.MakeChoice(s_sorts, t => $"if your array {t.Description}").Factory;

		var stopwatch = Stopwatch.StartNew();
		strategy.Sort(array);
		stopwatch.Stop();

		Console.WriteLine($"Result: ");
		Console.WriteLine($"-> is sorted: {SortingHelper.IsSorted(array)}");
		Console.WriteLine($"-> elapsed time: {1000.0 / Stopwatch.Frequency * stopwatch.ElapsedTicks} ms");
	}
}