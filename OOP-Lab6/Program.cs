using OOP_Lab6.Utilities;
using OOP_Lab6.CreationalPatternExample;
using OOP_Lab6.BehavioralPatternExample;

namespace OOP_Lab6;

class Program
{
	static readonly Dictionary<string, IClient> s_clients = new()
	{
		["c"] = new CreationalPatternClient(),
		["b"] = new BehavioralPatternClient(),
	};

	static void Main()
	{
		while (true)
		{
			var client = InputHelper.MakeChoice(s_clients,
				c => $"to choose {c.PatternType} pattern ({c.PatternName}) client");

			client.Main();

			Console.ReadLine();
			Console.Clear();
		}
	}
}
