using OOP_Lab6.Utilities;
using OOP_Lab6.BehavioralPatternExample;
using OOP_Lab6.CreationalPatternExample;
using OOP_Lab6.StructuralPatternExample;

namespace OOP_Lab6;

class Program
{
	static readonly Dictionary<string, IClient> s_clients = new()
	{
		["b"] = new BehavioralPatternClient(),
		["c"] = new CreationalPatternClient(),
		["s"] = new StructuralPatternClient()
	};

	static bool AskExit()
	{
		Console.WriteLine("Would you like to exit?");
		char i = InputHelper.GetCharInput("Y if yes or N if no", i => char.ToLower(i) is 'y' or 'n');
		return char.ToLower(i) == 'y';
	}

	static void Main()
	{
		do
		{
			Console.Clear();

			var client = InputHelper.MakeChoice(s_clients,
				c => $"to choose {c.PatternType} pattern ({c.PatternName}) client");

			client.Main();

			Console.WriteLine();

		} while (!AskExit());
	}
}
