using System.Diagnostics.CodeAnalysis;

namespace OOP_Lab6.Utilities;

public static class InputHelper
{
	public delegate bool TryParseHandler<T>(string s, [MaybeNullWhen(false)] out T res);

	public static T MakeChoice<T>(IDictionary<string, T> data, Func<T, string> getOptionDescription)
	{
		string message = string.Join(
			Environment.NewLine,
			data.Select(p => $"-> {p.Key} {getOptionDescription(p.Value)}").Prepend(string.Empty));
		return GetInput(message, (string k, [MaybeNullWhen(false)] out T v) => data.TryGetValue(k.ToLower(), out v));
	}

	public static int GetInt32Input(string name, Predicate<int>? condition = null)
		=> GetInput(name, int.TryParse, condition);

	public static char GetCharInput(string name, Predicate<char>? condition = null)
		=> GetInput(name, char.TryParse, condition);

	private static T GetInput<T>(string name, TryParseHandler<T> parse, Predicate<T>? condition = null)
	{
		Console.WriteLine($"Enter {name}");
		T? res;
		string input;
		do
		{
			Console.Write("> ");
			input = Console.ReadLine()!;
		} while (!parse(input, out res) || (condition is not null && !condition(res)));
		Console.WriteLine();
		return res;
	}
}
