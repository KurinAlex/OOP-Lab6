using System.Diagnostics.CodeAnalysis;
using static OOP_Lab6.Utilities.InputHelper;

namespace OOP_Lab6.Utilities;

public static class InputHelper
{
	public delegate bool TryParse<T>(string s, [MaybeNullWhen(false)] out T res);

	public static T MakeChoice<T>(Dictionary<string, T> data, Func<T, string> getOptionDescription)
	{
		string message = string.Join(
			Environment.NewLine,
			data.Select(p => $"-> {p.Key} {getOptionDescription(p.Value)}").Prepend(string.Empty));
		return GetInput<T>(message, data.TryGetValue);
	}

	public static int GetInt32Input(string name, Predicate<int>? conditions = null)
		=> GetInput(name, int.TryParse, conditions);

	private static T GetInput<T>(string name, TryParse<T> parser, Predicate<T>? conditions = null)
	{
		Console.WriteLine($"Enter {name}");
		T? res;
		string input;
		do
		{
			Console.Write("> ");
			input = Console.ReadLine()!;
		} while (!parser(input, out res) || (conditions is not null && !conditions(res)));
		Console.WriteLine();
		return res;
	}
}
