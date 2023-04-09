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
